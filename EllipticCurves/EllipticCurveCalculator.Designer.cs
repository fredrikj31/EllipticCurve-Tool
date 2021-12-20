namespace EllipticCurves {
	partial class EllipticCurveCalculator {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EllipticCurveCalculator));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxGenerator = new System.Windows.Forms.TextBox();
			this.textBoxCurveA = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxCurveB = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxKeyAlice = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxKeyBob = new System.Windows.Forms.TextBox();
			this.buttonGenerate = new System.Windows.Forms.Button();
			this.listBoxPointsAlice = new System.Windows.Forms.ListBox();
			this.listBoxPointsBob = new System.Windows.Forms.ListBox();
			this.textBoxPrivateAlice = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxPrivateBob = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxPublicAlice = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBoxPublicBob = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.buttonClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(317, 32);
			this.label1.TabIndex = 1250;
			this.label1.Text = "Elliptic Curve Calculator";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(289, 49);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 100;
			this.label2.Text = "Generator:";
			// 
			// textBoxGenerator
			// 
			this.textBoxGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxGenerator.Location = new System.Drawing.Point(351, 44);
			this.textBoxGenerator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxGenerator.Name = "textBoxGenerator";
			this.textBoxGenerator.Size = new System.Drawing.Size(130, 23);
			this.textBoxGenerator.TabIndex = 1;
			this.textBoxGenerator.Text = "1.5";
			// 
			// textBoxCurveA
			// 
			this.textBoxCurveA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCurveA.Location = new System.Drawing.Point(351, 70);
			this.textBoxCurveA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxCurveA.Name = "textBoxCurveA";
			this.textBoxCurveA.Size = new System.Drawing.Size(130, 23);
			this.textBoxCurveA.TabIndex = 2;
			this.textBoxCurveA.Text = "-2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(289, 75);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 300;
			this.label3.Text = "Curve (a):";
			// 
			// textBoxCurveB
			// 
			this.textBoxCurveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCurveB.Location = new System.Drawing.Point(351, 96);
			this.textBoxCurveB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxCurveB.Name = "textBoxCurveB";
			this.textBoxCurveB.Size = new System.Drawing.Size(130, 23);
			this.textBoxCurveB.TabIndex = 3;
			this.textBoxCurveB.Text = "2";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(289, 101);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 500;
			this.label4.Text = "Curve (b):";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(393, 137);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(2, 191);
			this.label5.TabIndex = 700;
			// 
			// textBoxKeyAlice
			// 
			this.textBoxKeyAlice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxKeyAlice.Location = new System.Drawing.Point(255, 394);
			this.textBoxKeyAlice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxKeyAlice.Name = "textBoxKeyAlice";
			this.textBoxKeyAlice.ReadOnly = true;
			this.textBoxKeyAlice.Size = new System.Drawing.Size(130, 23);
			this.textBoxKeyAlice.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(308, 379);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(28, 13);
			this.label6.TabIndex = 900;
			this.label6.Text = "Key:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(455, 379);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(28, 13);
			this.label7.TabIndex = 1100;
			this.label7.Text = "Key:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textBoxKeyBob
			// 
			this.textBoxKeyBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxKeyBob.Location = new System.Drawing.Point(403, 394);
			this.textBoxKeyBob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxKeyBob.Name = "textBoxKeyBob";
			this.textBoxKeyBob.ReadOnly = true;
			this.textBoxKeyBob.Size = new System.Drawing.Size(130, 23);
			this.textBoxKeyBob.TabIndex = 9;
			// 
			// buttonGenerate
			// 
			this.buttonGenerate.Location = new System.Drawing.Point(342, 345);
			this.buttonGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonGenerate.Name = "buttonGenerate";
			this.buttonGenerate.Size = new System.Drawing.Size(105, 30);
			this.buttonGenerate.TabIndex = 6;
			this.buttonGenerate.Text = "Generate Key";
			this.buttonGenerate.UseVisualStyleBackColor = true;
			this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
			// 
			// listBoxPointsAlice
			// 
			this.listBoxPointsAlice.FormattingEnabled = true;
			this.listBoxPointsAlice.Location = new System.Drawing.Point(15, 180);
			this.listBoxPointsAlice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.listBoxPointsAlice.Name = "listBoxPointsAlice";
			this.listBoxPointsAlice.Size = new System.Drawing.Size(374, 121);
			this.listBoxPointsAlice.TabIndex = 1000;
			// 
			// listBoxPointsBob
			// 
			this.listBoxPointsBob.FormattingEnabled = true;
			this.listBoxPointsBob.Location = new System.Drawing.Point(399, 180);
			this.listBoxPointsBob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.listBoxPointsBob.Name = "listBoxPointsBob";
			this.listBoxPointsBob.Size = new System.Drawing.Size(356, 121);
			this.listBoxPointsBob.TabIndex = 1001;
			// 
			// textBoxPrivateAlice
			// 
			this.textBoxPrivateAlice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPrivateAlice.Location = new System.Drawing.Point(99, 137);
			this.textBoxPrivateAlice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxPrivateAlice.Name = "textBoxPrivateAlice";
			this.textBoxPrivateAlice.Size = new System.Drawing.Size(130, 23);
			this.textBoxPrivateAlice.TabIndex = 4;
			this.textBoxPrivateAlice.Text = "10";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 142);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(83, 13);
			this.label8.TabIndex = 1500;
			this.label8.Text = "Private Number:";
			// 
			// textBoxPrivateBob
			// 
			this.textBoxPrivateBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPrivateBob.Location = new System.Drawing.Point(484, 137);
			this.textBoxPrivateBob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxPrivateBob.Name = "textBoxPrivateBob";
			this.textBoxPrivateBob.Size = new System.Drawing.Size(130, 23);
			this.textBoxPrivateBob.TabIndex = 5;
			this.textBoxPrivateBob.Text = "50";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(400, 142);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(83, 13);
			this.label9.TabIndex = 1700;
			this.label9.Text = "Private Number:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(399, 164);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(39, 13);
			this.label10.TabIndex = 1900;
			this.label10.Text = "Points:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(16, 164);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(39, 13);
			this.label11.TabIndex = 2000;
			this.label11.Text = "Points:";
			// 
			// textBoxPublicAlice
			// 
			this.textBoxPublicAlice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPublicAlice.Location = new System.Drawing.Point(99, 311);
			this.textBoxPublicAlice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxPublicAlice.Name = "textBoxPublicAlice";
			this.textBoxPublicAlice.ReadOnly = true;
			this.textBoxPublicAlice.Size = new System.Drawing.Size(130, 23);
			this.textBoxPublicAlice.TabIndex = 2001;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(16, 316);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(79, 13);
			this.label12.TabIndex = 2002;
			this.label12.Text = "Public Number:";
			// 
			// textBoxPublicBob
			// 
			this.textBoxPublicBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPublicBob.Location = new System.Drawing.Point(484, 311);
			this.textBoxPublicBob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxPublicBob.Name = "textBoxPublicBob";
			this.textBoxPublicBob.ReadOnly = true;
			this.textBoxPublicBob.Size = new System.Drawing.Size(130, 23);
			this.textBoxPublicBob.TabIndex = 2003;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(400, 316);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(79, 13);
			this.label13.TabIndex = 2004;
			this.label13.Text = "Public Number:";
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(659, 11);
			this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(98, 40);
			this.buttonClear.TabIndex = 2005;
			this.buttonClear.Text = "Clear Calculations";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// EllipticCurveCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 439);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.textBoxPublicBob);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.textBoxPublicAlice);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBoxPrivateBob);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBoxPrivateAlice);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.listBoxPointsBob);
			this.Controls.Add(this.listBoxPointsAlice);
			this.Controls.Add(this.buttonGenerate);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxKeyBob);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxKeyAlice);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxCurveB);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxCurveA);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxGenerator);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "EllipticCurveCalculator";
			this.Text = "Elliptic Curve - Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxGenerator;
		private System.Windows.Forms.TextBox textBoxCurveA;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxCurveB;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxKeyAlice;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxKeyBob;
		private System.Windows.Forms.Button buttonGenerate;
		private System.Windows.Forms.ListBox listBoxPointsAlice;
		private System.Windows.Forms.ListBox listBoxPointsBob;
		private System.Windows.Forms.TextBox textBoxPrivateAlice;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxPrivateBob;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxPublicAlice;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBoxPublicBob;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button buttonClear;
	}
}