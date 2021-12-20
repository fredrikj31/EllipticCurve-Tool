using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace EllipticCurves {
	public class EllipticCurve {
		private Random rnd;

		// Curve Variables
		private double a;
		private double b;

		private int prime = 7;

		public EllipticCurve(double inputA, double inputB) {
			this.rnd = new Random();

			this.a = inputA;
			this.b = inputB;
		}

		public double calculateYValue(double x) {
			double y = (Math.Sqrt(Math.Pow(x, 3) + (this.a * x) + this.b)) % this.prime;

			return y;
		}

		public Point calculateFirstPoint() {
			double randomValue = rnd.NextDouble();

			double xValue = randomValue;
			double yValue = this.calculateYValue(xValue);

			return new Point(xValue, yValue);
		}

		public Point calculateGenerator() {
			double x = rnd.NextDouble();

			double y = this.calculateYValue(x);

			Point point = new Point(x, y);

			return point;
		}

		/*public Point calculateNextPoint(Point p1, Point p2) {
			double lambda = (p2.y - p1.y) / (p2.x - p1.x);
			double xPoint = Math.Pow(lambda, 2) - p1.x - p2.x;
			double yPoint = (p1.x - xPoint) * p1.y;

			Point newPoint = new Point(xPoint, yPoint);

			return newPoint;
		}*/

		public Point calculateNextPointWithPoints(Point p1, Point p2) {

			double slope = (p2.y - p1.y) / (p2.x - p1.x);

			double xPoint = Math.Pow(slope, 2) - p2.x - p1.x;
			double yPoint = p2.y + slope * (xPoint - p2.x);

			Point result = new Point(xPoint, (-1 * yPoint));

			return result;
		}

		//public Point calculateNextPoint(Point p) {
		//	double slope = (3.0 * Math.Pow(p.x, 2) + this.a) / (2.0 * p.y);

		//	double xPoint = (Math.Pow(slope, 2) - 2.0 * p.x);
		//	double yPoint = -1 * (p.y + slope * (xPoint - p.x));

		//	return new Point(xPoint, yPoint);
		//}

		//public Point calculateIntersectionPoint(Point a, Point b) {
		//	// Calculate slope
		//	double slope = (b.y - a.y) / (b.x - a.x);

		//	// Calculate the intersection with y-axis
		//	double linearIntersection = a.y - slope * a.x;

		//	// Calculate intersection with the 2 lines Sqrt(x^3+a*x+b)=a*x+b
		//	double looongEquation = Math.Pow(
		//		72 * Math.Pow(slope, 3) * 
		//		linearIntersection - 36 * 
		//		this.a * Math.Pow(slope, 2) + 
		//		108 * Math.Pow(linearIntersection, 2) - 
		//		108 * linearIntersection + 8 * 
		//		Math.Pow(slope, 6) + 12 *
		//		(Math.Sqrt(12 * Math.Pow(slope, 5) * 
		//		linearIntersection * this.a - 12 * 
		//		linearIntersection * Math.Pow(slope, 6) - 
		//		3 * Math.Pow(this.a, 2) * 
		//		Math.Pow(slope, 4) + 12 *
		//		Math.Pow(slope, 3) * Math.Pow(linearIntersection, 3) + 
		//		90 * Math.Pow(slope, 2) * 
		//		Math.Pow(linearIntersection, 2) * this.a - 
		//		108 * Math.Pow(slope, 3) * 
		//		Math.Pow(linearIntersection, 2) - 72 * 
		//		slope * linearIntersection * 
		//		Math.Pow(this.a, 2) + 54 * 
		//		this.a * Math.Pow(slope, 2) * 
		//		linearIntersection + 81 * 
		//		Math.Pow(linearIntersection, 4) + 12 * 
		//		Math.Pow(this.a, 3) - 162 * 
		//		Math.Pow(linearIntersection, 3) + 81 * 
		//		Math.Pow(linearIntersection, 2))), (1.0 / 3.0));

		//	double tempEquation1 = looongEquation / 6.0;

		//	double tempEquation2 = 6 * (-(2.0 / 3.0)) * slope * linearIntersection + (1.0 / 3.0) * slope - (1.0 / 9.0) * Math.Pow(slope, 4) / looongEquation;

		//	double tempEquation3 = (Math.Pow(slope, 2)) / 3.0;

		//	double intersectionXValue = tempEquation1 - tempEquation2 + tempEquation3;

		//	double intersectionYValue = this.calculateYValue(intersectionXValue);

		//	Point point = new Point(intersectionXValue, intersectionYValue);

		//	return point;
		//}
	}
}
