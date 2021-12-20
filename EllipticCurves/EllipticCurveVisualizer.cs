using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EllipticCurves {
	public partial class EllipticCurveVisualizer : Form {
		private EllipticCurve curve;
		private Visual visual;
		private Point generatorPoint;
		private Point latestPoint;
		private int pointNum = 0;

		public EllipticCurveVisualizer() {
			InitializeComponent();
			this.curve = new EllipticCurve(-2, 2);
			this.visual = new Visual(this.curve, chartMain, -4, 200);
		}

		private void Form1_Load(object sender, EventArgs e) {
			this.visual.drawCurve();
			this.generatorPoint = this.curve.calculateGenerator();
			this.latestPoint = this.curve.calculateFirstPoint();
			this.visual.drawPoint("Generator", this.generatorPoint, "G");
			this.visual.drawPoint("Points", this.latestPoint, "P0");

			this.textBoxPointX.Text = this.latestPoint.x.ToString();
			this.textBoxPointY.Text = this.latestPoint.y.ToString();
			this.textBoxPointNum.Text = this.pointNum.ToString();

			//this.curve.calculateIntersectionPoint(generatorPoint, new Point(1,1));
		}

		private void buttonAddPoint_Click(object sender, EventArgs e) {
			Point tempPoint = this.curve.calculateNextPointWithPoints(this.generatorPoint, this.latestPoint);
			this.latestPoint = tempPoint;
			this.pointNum++;
			this.visual.drawPoint("Points", this.latestPoint, "P" + this.pointNum.ToString());

			this.textBoxPointX.Text = tempPoint.x.ToString();
			this.textBoxPointY.Text = tempPoint.y.ToString();
			this.textBoxPointNum.Text = this.pointNum.ToString();
		}

		private void zoomInToolStripMenuItem_Click(object sender, EventArgs e) {
			this.visual.zoomIn();
		}

		private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e) {
			this.visual.zoomOut();
		}
		private void zoomResetToolStripMenuItem_Click(object sender, EventArgs e) {
			this.visual.resetZoom();
		}

		private void resetToolStripMenuItem_Click(object sender, EventArgs e) {
			this.visual.resetPoint("Points");
			this.visual.resetPoint("Generator");
			this.pointNum = 0;

			this.generatorPoint = this.curve.calculateGenerator();
			this.latestPoint = this.curve.calculateFirstPoint();
			this.visual.drawPoint("Generator", this.generatorPoint, "G");
			this.visual.drawPoint("Points", this.latestPoint, "P0");

			this.textBoxPointX.Text = this.latestPoint.x.ToString();
			this.textBoxPointY.Text = this.latestPoint.y.ToString();
			this.textBoxPointNum.Text = this.pointNum.ToString();

		}


		private void Form1_KeyDown(object sender, KeyEventArgs e) {

			// Reset zoom factor
			if (e.Control && e.KeyCode == Keys.I) {
				this.visual.resetZoom();
			}

			// Zoom Out Shortcut
			if (e.Control && e.KeyCode == Keys.P) {
				this.visual.zoomOut();
			}

			// Zoom In Shortcut
			if (e.Control && e.KeyCode == Keys.O) {
				this.visual.zoomIn();
			}
		}

		private void EllipticCurveVisualizer_SizeChanged(object sender, EventArgs e) {
			Debug.WriteLine("Height: " + this.Size.Height);
			Debug.WriteLine("Width: " + this.Size.Width);
		}
	}
}
