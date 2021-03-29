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
			double x = xMin;
			double y;

			while (x <= xMax){
				y = Math.Pow(x, 2);
				Console.WriteLine("x = {0}\t\t y = {1}", x, y);
				x += dx;
			}

			if (Math.Abs(x - xMax - dx) > 0.0001) {
				y = Math.Pow(xMax, 2);
				Console.WriteLine("x = {0}\t\t y = {1}", xMax, y);
			}
        }
    }
}
