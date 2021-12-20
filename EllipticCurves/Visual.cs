using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EllipticCurves {
	public class Visual {

		private EllipticCurve curve;

		private Chart chart;
		private int minX;
		private int maxX;

		private double zoomFactor = 5.0;

		public Visual(EllipticCurve curve, Chart myChart, int minX, int maxX) {
			this.chart = myChart;
			this.minX = minX;
			this.maxX = maxX;
			this.curve = curve;

			this.chart.ChartAreas[0].AxisX.ScaleView.Zoom(-1 * this.zoomFactor, this.zoomFactor);
			this.chart.ChartAreas[0].AxisY.ScaleView.Zoom(-1 * this.zoomFactor, this.zoomFactor);
		}

		public void resetZoom() {
			this.zoomFactor = 5.0;
			// Sets the x-axis
			this.chart.ChartAreas[0].AxisX.ScaleView.Zoom(-1 * this.zoomFactor, this.zoomFactor);
			// Sets the y-axis
			this.chart.ChartAreas[0].AxisY.ScaleView.Zoom(-1 * this.zoomFactor, this.zoomFactor);
		}

		public void zoomIn() {
			if (zoomFactor == 5.0) {
				MessageBox.Show("You cant zoom more in.", "Zoom Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} else {
				this.zoomFactor = this.zoomFactor - 5.0;

				// Sets the x-axis
				this.chart.ChartAreas[0].AxisX.ScaleView.Zoom(-1 * this.zoomFactor, this.zoomFactor);
				// Sets the y-axis
				this.chart.ChartAreas[0].AxisY.ScaleView.Zoom(-1 * this.zoomFactor, this.zoomFactor);
			}
		}
		public void zoomOut() {
			this.zoomFactor = this.zoomFactor + 5.0;

			// Sets the x-axis
			this.chart.ChartAreas[0].AxisX.ScaleView.Zoom(-1 * this.zoomFactor, this.zoomFactor);
			// Sets the y-axis
			this.chart.ChartAreas[0].AxisY.ScaleView.Zoom(-1 * this.zoomFactor, this.zoomFactor);
		}

		public void resetPoint(string seriesName) {
			this.chart.Series[seriesName].Points.Clear();
		}

		public void drawCurve() {
			double xPos = this.minX;
			double xPos2 = this.minX;

			// Generating the top layer of the curve
			while (xPos < this.maxX) {
				double y = this.curve.calculateYValue(xPos);
				this.chart.Series[0].Points.AddXY(xValue: xPos, yValue: y);
				xPos += 0.1;
			}

			// Generating the bottom layer of the curve
			while (xPos2 < this.maxX) {
				double y2 = (-1) * this.curve.calculateYValue(xPos2);
				this.chart.Series[0].Points.AddXY(xValue: xPos2, yValue: y2);
				xPos2 += 0.1;

				//Debug.WriteLine(y2);
			}
		}

		public void drawPoint(string seriesName, Point point, string labelName) {
			DataPoint tempPoint = this.chart.Series[seriesName].Points.Add(new double[] { point.y });
			tempPoint.XValue = point.x;
			tempPoint.Label = labelName;
		}
	}
}
