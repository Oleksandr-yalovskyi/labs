using System;

namespace l19 {
    class Program {
        static void Main(string[] args) {
        	StartOfCalculations:
            Console.Write("Введiть початок вiдрiзку iнтегрування a: ");
			string sa = Console.ReadLine();
			double a = double.Parse(sa);

			Console.Write("Введiть кiнець вiдрiзку iнтегрування b: ");
			string sb = Console.ReadLine();
			double b = double.Parse(sb);

			Console.Write("Введiть кiлькiсть дiлянок n: ");
			string sn = Console.ReadLine();
			double n = double.Parse(sn);

			double dx = (b - a) / n;
			double y1, y2;
			double x1, x2;
			double Intgrl = 0;

			for (int i = 1; i <= n; i++){
				x1 = (a + i * dx) * 2;
				x2 = (x1 + dx) * 5;
				y1 = Math.Sin(x1) + Math.Pow(x1, 0.5) - 1.3 * Math.Pow(x1, 3);
				y2 = Math.Pow(x2, 3);
				Intgrl += (y1 - y2) * dx;
			}
			Console.WriteLine("Iнтеграл функцiї на вiдрiзку [{0}, {1}] становить {2:0.00000}", a, b, Intgrl);

			Console.Write("Повторити розрахунок (y - так) ? ");
			ConsoleKeyInfo pressedKey = Console.ReadKey();
			Console.WriteLine();
			if (pressedKey.Key == ConsoleKey.Y){
				Console.WriteLine();
				goto StartOfCalculations;
			}
        }
    }
}
