namespace EllipticCurves {
	partial class MainMenu {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
			this.buttonVisualizer = new System.Windows.Forms.Button();
			this.buttonCalculator = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// buttonVisualizer
			// 
			this.buttonVisualizer.Location = new System.Drawing.Point(98, 186);
			this.buttonVisualizer.Name = "buttonVisualizer";
			this.buttonVisualizer.Size = new System.Drawing.Size(140, 62);
			this.buttonVisualizer.TabIndex = 0;
			this.buttonVisualizer.Text = "Open Visualizer";
			this.buttonVisualizer.UseVisualStyleBackColor = true;
			this.buttonVisualizer.Click += new System.EventHandler(this.buttonVisualizer_Click);
			// 
			// buttonCalculator
			// 
			this.buttonCalculator.Location = new System.Drawing.Point(547, 186);
			this.buttonCalculator.Name = "buttonCalculator";
			this.buttonCalculator.Size = new System.Drawing.Size(140, 62);
			this.buttonCalculator.TabIndex = 1;
			this.buttonCalculator.Text = "Open Calculator";
			this.buttonCalculator.UseVisualStyleBackColor = true;
			this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new System.Drawing.Point(245, 401);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Created By: Fredrik Johansen";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(227, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(359, 48);
			this.label2.TabIndex = 3;
			this.label2.Text = "Elliptic Curve Tool";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = System.Drawing.SystemColors.MenuHighlight;
			this.linkLabel1.Location = new System.Drawing.Point(435, 401);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(114, 16);
			this.linkLabel1.TabIndex = 4;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "fredrikj31.github.io";
			this.linkLabel1.VisitedLinkColor = System.Drawing.SystemColors.MenuHighlight;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCalculator);
			this.Controls.Add(this.buttonVisualizer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainMenu";
			this.Text = "Elliptic Curve - Main Menu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonVisualizer;
		private System.Windows.Forms.Button buttonCalculator;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}