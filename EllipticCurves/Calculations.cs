using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllipticCurves {
	class Calculations {
		public double generateCurve(bool isTop, double x, double a, double b) {
			if (isTop) {
				double y = Math.Sqrt(Math.Pow(x, 3) + (a * x) + b);

				return y;
			} else {
				double y = -Math.Sqrt(Math.Pow(x, 3) + (a * x) + b);

				return y;
			}
		}

		public double[] createGenerator() {
			Random rnd = new Random();

			double x = rnd.NextDouble();

			double y = Math.Sqrt(Math.Pow(x, 3) + (-2.0) * x + 2.0);

			double[] list = { x, y };

			return list;
		} 
	}
}
