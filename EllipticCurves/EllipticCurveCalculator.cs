using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EllipticCurves {
	public partial class EllipticCurveCalculator : Form {

		private EllipticCurve curve;
		private double curveA;
		private double curveB;
		private double generator;
		private double privateAlice;
		private double privateBob;
		private Point publicAlice;
		private Point publicBob;

		private Point generatorPoint;
		private Point firstPoint;
		private Point latestPoint;

		public EllipticCurveCalculator() {
			InitializeComponent();
		}

		public bool checkTextBox(TextBox input) {
			if (input.Text != string.Empty) {
				return true;
			} else {
				return false;
			}
		}

		private Point calculateAlice() {
			// Generating the first points
			this.latestPoint = this.curve.calculateNextPointWithPoints(this.generatorPoint, this.firstPoint);

			this.listBoxPointsAlice.Items.Add("G: " + "(" + this.generatorPoint.x.ToString() + " ; " + this.generatorPoint.y.ToString() + ")");
			this.listBoxPointsAlice.Items.Add("P0: " + "(" + this.latestPoint.x.ToString() + " ; " + this.latestPoint.y.ToString() + ")");

			int i = 1;
			while (i < this.privateAlice) {
				Point tempPoint = this.curve.calculateNextPointWithPoints(this.generatorPoint, this.latestPoint);

				this.listBoxPointsAlice.Items.Add("P" + i.ToString() + ": " + "(" + tempPoint.x.ToString() + " ; " + tempPoint.y.ToString() + ")");
				this.latestPoint = tempPoint;
				i++;
			}

			this.textBoxPublicAlice.Text = this.latestPoint.x.ToString();

			return this.latestPoint;
		}

		private Point calculateBob() {
			// Generating the first points
			this.latestPoint = this.curve.calculateNextPointWithPoints(this.generatorPoint, this.firstPoint);

			this.listBoxPointsBob.Items.Add("G: " + "(" + this.generatorPoint.x.ToString() + " ; " + this.generatorPoint.y.ToString() + ")");
			this.listBoxPointsBob.Items.Add("P0: " + "(" + this.latestPoint.x.ToString() + " ; " + this.latestPoint.y.ToString() + ")");

			int i = 1;
			while (i < this.privateBob) {
				Point tempPoint = this.curve.calculateNextPointWithPoints(this.generatorPoint, this.latestPoint);

				this.listBoxPointsBob.Items.Add("P" + i.ToString() + ": " + "(" + tempPoint.x.ToString() + " ; " + tempPoint.y.ToString() + ")");
				this.latestPoint = tempPoint;
				i++;
			}

			this.textBoxPublicBob.Text = this.latestPoint.x.ToString();

			return this.latestPoint;
		}

		private double calculateKeyAlice(Point bobPublic) {

			// Generating the first points
			this.latestPoint = this.curve.calculateNextPointWithPoints(this.generatorPoint, this.firstPoint);

			int times = 1;
			while (bobPublic.x != this.latestPoint.x && bobPublic.y != this.latestPoint.y) {
				this.latestPoint = this.curve.calculateNextPointWithPoints(this.generatorPoint, this.latestPoint);
				times++;
				continue;
			}
			//Debug.WriteLine("Bob did " + times);

			for (int i = 0; i < (times * this.privateAlice); i++) {
				// Resets starter point
				this.latestPoint = this.firstPoint;

				Point tempPoint = this.curve.calculateNextPointWithPoints(this.generatorPoint, this.latestPoint);
				this.latestPoint = tempPoint;
			}

			Debug.WriteLine(this.latestPoint.x + " ; " + this.latestPoint.y);

			return this.latestPoint.x;
		}
		private double calculateKeyBob(Point alicePublic) {
			// Generating the first points
			this.latestPoint = this.curve.calculateNextPointWithPoints(this.generatorPoint, this.firstPoint);

			// Find how many times the other person have done it through
			int times = 1;
			while (alicePublic.x != this.latestPoint.x && alicePublic.y != this.latestPoint.y) {
				this.latestPoint = this.curve.calculateNextPointWithPoints(this.generatorPoint, this.latestPoint);
				times++;
				continue;
			}
			//Debug.WriteLine("Alice did " + times);

			for (int i = 0; i < (times * this.privateBob); i++) {
				// Resets starter point
				this.latestPoint = this.firstPoint;

				Point tempPoint = this.curve.calculateNextPointWithPoints(this.generatorPoint, this.latestPoint);
				this.latestPoint = tempPoint;
			}

			Debug.WriteLine(this.latestPoint.x + " ; " + this.latestPoint.y);

			return this.latestPoint.x;
		}

		private void buttonGenerate_Click(object sender, EventArgs e) {
			// Check if curve fields are filled
			if (this.checkTextBox(textBoxCurveA) && this.checkTextBox(textBoxCurveB) && this.checkTextBox(textBoxGenerator) && this.checkTextBox(this.textBoxPrivateAlice) && this.checkTextBox(this.textBoxPrivateBob)) {

				// Converting into doubles
				try {
					this.curveA = double.Parse(textBoxCurveA.Text);
					this.curveB = double.Parse(textBoxCurveB.Text);
					this.generator = double.Parse(textBoxGenerator.Text);
					this.privateAlice = double.Parse(textBoxPrivateAlice.Text);
					this.privateBob = double.Parse(textBoxPrivateBob.Text);
				} catch (FormatException ex) {
					MessageBox.Show("Please type a number into each field, not a text.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					Debug.WriteLine(ex.Message);
				}

				this.curve = new EllipticCurve(this.curveA, this.curveB);
				this.firstPoint = this.curve.calculateFirstPoint();

				// Calculate generator point
				this.generatorPoint = new Point(this.generator, this.curve.calculateYValue(this.generator));

				// Making calculations for Alice
				this.publicAlice = this.calculateAlice();

				// Making calculations for Bob
				this.publicBob = this.calculateBob();

				// Generating key for Alice
				textBoxKeyAlice.Text = this.calculateKeyAlice(this.publicBob).ToString();
				// Generating key for Bob
				textBoxKeyBob.Text = this.calculateKeyBob(this.publicAlice).ToString();

			} else {
				MessageBox.Show("Please fill in all input fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void buttonClear_Click(object sender, EventArgs e) {
			// Clearing all textboxes
			textBoxCurveA.Text = "";
			textBoxCurveB.Text = "";
			textBoxGenerator.Text = "";
			textBoxKeyAlice.Text = "";
			textBoxKeyBob.Text = "";
			textBoxPrivateAlice.Text = "";
			textBoxPrivateBob.Text = "";
			textBoxPublicAlice.Text = "";
			textBoxPublicBob.Text = "";

			listBoxPointsAlice.Items.Clear();
			listBoxPointsBob.Items.Clear();

			// Clearing all variables
			this.curve = null;
			this.curveA = 0.0;
			this.curveB = 0.0;
			this.generator = 0.0;
			this.privateAlice = 0.0;
			this.privateBob = 0.0;
			this.publicAlice = null;
			this.publicBob = null;

			this.generatorPoint = null;
			this.latestPoint = null;
		}
	}
}
