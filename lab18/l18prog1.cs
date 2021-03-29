using System;

namespace l18 {
    class Program {
        static void Main(string[] args) {
			Console.Write("Введiть початкове значення Xmin: ");
			string sxMin = Console.ReadLine();
			double xMin = Double.Parse(sxMin);

			Console.Write("Введiть кiнцеве значення Xmax: ");
			string sxMax = Console.ReadLine();
			double xMax = double.Parse(sxMax);

			Console.Write("Введiть прирiст dX: ");
			string sdx = Console.ReadLine();
			double dx = double.Parse(sdx);
			double x1 = xMin;
			double x2 = 3 * x1;
			double y;


			while (x1 <= xMax) {
				y = Math.Cos(Math.Pow(x2, 0.5)) + 34 * Math.Sin(x1) - 4 * Math.Sin(x2);
				Console.WriteLine("x1 = {0}\t\t x2 = {1}\t\t y = {2}", x1, x2, y);
				x1 += dx;
				x2 = 3 * x1;
			}


			if (Math.Abs(x1 - xMax - dx) > 0.0001){
				y = Math.Pow(xMax, 2);
				Console.WriteLine("x = {0}\t\t y = {1}", xMax, y);
			}
        }
    }
}
