
namespace EllipticCurves {
	partial class EllipticCurveVisualizer {
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EllipticCurveVisualizer));
			this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.buttonAddPoint = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxPointNum = new System.Windows.Forms.TextBox();
			this.textBoxPointX = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPointY = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chartMain
			// 
			chartArea4.AxisX.LabelStyle.Format = "0.00";
			chartArea4.AxisX.ScaleView.Zoomable = false;
			chartArea4.AxisY.LabelStyle.Format = "0.00";
			chartArea4.AxisY.ScaleView.Zoomable = false;
			chartArea4.Name = "ChartArea1";
			this.chartMain.ChartAreas.Add(chartArea4);
			legend4.Name = "Legend1";
			this.chartMain.Legends.Add(legend4);
			this.chartMain.Location = new System.Drawing.Point(16, 33);
			this.chartMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chartMain.Name = "chartMain";
			series10.ChartArea = "ChartArea1";
			series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series10.Legend = "Legend1";
			series10.MarkerSize = 1;
			series10.Name = "The Curve";
			series11.ChartArea = "ChartArea1";
			series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series11.Legend = "Legend1";
			series11.Name = "Generator";
			series12.ChartArea = "ChartArea1";
			series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series12.Legend = "Legend1";
			series12.Name = "Points";
			this.chartMain.Series.Add(series10);
			this.chartMain.Series.Add(series11);
			this.chartMain.Series.Add(series12);
			this.chartMain.Size = new System.Drawing.Size(1035, 506);
			this.chartMain.TabIndex = 0;
			this.chartMain.Text = "Chart";
			// 
			// buttonAddPoint
			// 
			this.buttonAddPoint.Location = new System.Drawing.Point(872, 422);
			this.buttonAddPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonAddPoint.Name = "buttonAddPoint";
			this.buttonAddPoint.Size = new System.Drawing.Size(149, 34);
			this.buttonAddPoint.TabIndex = 1;
			this.buttonAddPoint.Text = "Add Point";
			this.buttonAddPoint.UseVisualStyleBackColor = true;
			this.buttonAddPoint.Click += new System.EventHandler(this.buttonAddPoint_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.pointsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoomResetToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// zoomInToolStripMenuItem
			// 
			this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
			this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
			this.zoomInToolStripMenuItem.Text = "Zoom In";
			this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
			// 
			// zoomOutToolStripMenuItem
			// 
			this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
			this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
			this.zoomOutToolStripMenuItem.Text = "Zoom Out";
			this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
			// 
			// zoomResetToolStripMenuItem
			// 
			this.zoomResetToolStripMenuItem.Name = "zoomResetToolStripMenuItem";
			this.zoomResetToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
			this.zoomResetToolStripMenuItem.Text = "Zoom Reset";
			this.zoomResetToolStripMenuItem.Click += new System.EventHandler(this.zoomResetToolStripMenuItem_Click);
			// 
			// pointsToolStripMenuItem
			// 
			this.pointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
			this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
			this.pointsToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
			this.pointsToolStripMenuItem.Text = "Points";
			// 
			// resetToolStripMenuItem
			// 
			this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
			this.resetToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
			this.resetToolStripMenuItem.Text = "Reset";
			this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(840, 319);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Point #:";
			// 
			// textBoxPointNum
			// 
			this.textBoxPointNum.Location = new System.Drawing.Point(905, 314);
			this.textBoxPointNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxPointNum.Name = "textBoxPointNum";
			this.textBoxPointNum.ReadOnly = true;
			this.textBoxPointNum.Size = new System.Drawing.Size(132, 22);
			this.textBoxPointNum.TabIndex = 4;
			// 
			// textBoxPointX
			// 
			this.textBoxPointX.Location = new System.Drawing.Point(905, 359);
			this.textBoxPointX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxPointX.Name = "textBoxPointX";
			this.textBoxPointX.ReadOnly = true;
			this.textBoxPointX.Size = new System.Drawing.Size(132, 22);
			this.textBoxPointX.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(840, 364);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Point X:";
			// 
			// textBoxPointY
			// 
			this.textBoxPointY.Location = new System.Drawing.Point(905, 391);
			this.textBoxPointY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxPointY.Name = "textBoxPointY";
			this.textBoxPointY.ReadOnly = true;
			this.textBoxPointY.Size = new System.Drawing.Size(132, 22);
			this.textBoxPointY.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(840, 395);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Point Y:";
			// 
			// EllipticCurveVisualizer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.textBoxPointY);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxPointX);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPointNum);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAddPoint);
			this.Controls.Add(this.chartMain);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "EllipticCurveVisualizer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Elliptic Curve - Visualizer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.SizeChanged += new System.EventHandler(this.EllipticCurveVisualizer_SizeChanged);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
		private System.Windows.Forms.Button buttonAddPoint;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxPointNum;
		private System.Windows.Forms.TextBox textBoxPointX;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripMenuItem zoomResetToolStripMenuItem;
		private System.Windows.Forms.TextBox textBoxPointY;
		private System.Windows.Forms.Label label3;
	}
}

