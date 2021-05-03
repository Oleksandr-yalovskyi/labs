//ex1
using System;

namespace l21{
    class Program{
        private static int Sum(int x, int y){
            int z = x + y;

            return z;
        }
        static void Main(string[] args){
            int res = Sum(2, 2);

            Console.WriteLine(res);

            int a = 3;
            int b = 4;

            Console.WriteLine(Sum(a, b));
        }
    }
}
//ex2-----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        private static double DivWithoutExeption(double x, double y){
            if (y == 0){
                return double.MaxValue;
            } else {
                return x / y;
            }
        }
        static void Main(string[] args){
            Console.WriteLine(DivWithoutExeption(1 , 0));
            Console.WriteLine(DivWithoutExeption(15.1 , 2));
        }
    }
}
//ex3-----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        static void PrintDigit(){
            Random random = new Random();
            Console.WriteLine(random.Next(11));
        }
        static void Main(string[] args){
            PrintDigit();
        }
    }
}
//ex4-----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        private static int[] instanceArray(int size, int min, int max){
			Random random = new Random();
			int [] mas = new int[size];

			for (int i = 0; i < mas.Length; i++){
				mas[i] = random.Next(min, max);
			}

			return mas;
		}
        static void Main(string[] args){
            int[] arr = instanceArray(5, 0, 10);
			foreach (int a in arr){
				Console.Write($"{a} ");
			}
        }
    }
}
//ex5-----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        private static void PrintArray(int[,] mas){
			for (int i = 0; i < mas.GetLength(0); i++){			
				for (int j = 0; j < mas.GetLength(1); j++)
					Console.Write($"{mas[i, j]} ");
			Console.WriteLine();
			}
		}

		private static int[,] InitArray(int n, int m){
			Random rand = new Random();
			int [,] mas = new int[n,m];

			for(int i=0; i<mas.GetLength(0);i++)
				for (int j = 0; j < mas.GetLength(1); j++)
					mas[i, j] = rand.Next(10, 100);

			return mas;
		}
        static void Main(string[] args){
            int[,] arr = InitArray(4, 5);
			PrintArray(arr);
        }
    }
}
//ex6-----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        private static int Sum4Arg(int i1, int i2, int i3, int i4){
			return i1 + i2 + i3 + i4;
		}
		private static int Sum3Arg(int i1, int i2, int i3){
			return i1 + i2 + i3;
		}
		private static int Sum2Arg(int i1, int i2){
			return i1 + i2;
		}
        static void Main(string[] args){
            int a = Sum2Arg(2, 3);
			int b = Sum3Arg(2, 3, 4);
			int c = Sum4Arg(2, 3, 4, 5);

			Console.WriteLine($"a={a} b={b} c={c}");
        }
    }
}
//ex7-----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        private static int Sum(int i1, int i2, int i3 = 0, int i4 = 0){
			return i1 + i2 + i3 + i4;
		}
        static void Main(string[] args){
            int a = Sum(2, 3);
			int b = Sum(2, 3, 4);
			int c = Sum(2, 3, 4, 5);

			Console.WriteLine($"a={a} b={b} c={c}");
        }
    }
}
//ex8-----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        private static double Sum(double d1, double d2){
            return d1 + d2;
        }
        private static int Sum(int i1, int i2){
            return i1 + i2;
        }
        static void Main(string[] args){
            int a = Sum(2, 3);
            double b = Sum(2.0, 3.0);

            Console.WriteLine($"a={a} b={b}");
        }
    }
}
//ex9-----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        private static void SumAndPrint(double d1, double d2){
            Console.WriteLine(d1+d2);
        }
        private static void SumAndPrint(int d1, int d2){
            Console.WriteLine(d1 + d2);
        }
        static void Main(string[] args){
            SumAndPrint(2,3);
            SumAndPrint(2.0, 3.1);
        }
    }
}
//ex10----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        private static int Sum(int i1, int i2, int i3, int i4){
            return i1 + i2 + i3 + i4;
        }
        private static int Sum(int i1, int i2, int i3){
            return Sum(i1 , i2 , i3, 0);
        }
        private static int Sum(int i1, int i2){
            return Sum(i1 , i2 , 0);
        }
        static void Main(string[] args){
            int a = Sum(2, 3);
            int b = Sum(2, 3, 4);
            int c = Sum(2, 3, 4, 5);

            Console.WriteLine($"a={a} b={b} c={c}");
        }
    }
}
//ex11----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        private static void PrintArray(int[,] mas){
            for (int i = 0; i < mas.GetLength(0); i++){
                for (int j = 0; j < mas.GetLength(1); j++){
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        private static void PrintArray(int[] mas){
            for ( int i = 0; i < mas.GetLength(1); i++ ) {
                Console.Write($"{mas[i]} \n");
            }
        }
        static void Main(string[] args){
            int[] arr = {2,3,4,5};
            int[,] arr1 = { {2,3}, {4, 5}};

            PrintArray(arr);
            PrintArray(arr1);
        }
    }
}
//ex12----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        private static int[,] InitArray(int n, int m) {
            Random rand = new Random();
            int[,] mas = new int[n,m];

            for(int i=0; i<mas.GetLength(0);i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    mas[i, j] = rand.Next(10, 100);

            return mas;
        }
        private static int[][] InitJuggedArray(int n, int m){
            Random rand = new Random();
            int[][] mas = new int[n][];
            for ( int i = 0; i < mas.Length; i++){
                mas[i] = new int[m];
            }
            for ( int i = 0; i < mas.Length; i++ ) {
                for ( int j = 0; j < mas[i].Length; j++ ) {
                    mas[i][j] = rand.Next(10, 100);
                }
            }

            return mas;
        }
        private static void PrintArray(int[,] mas){
            for (int i = 0; i < mas.GetLength(0); i++){
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write($"{mas[i, j]} ");
            Console.WriteLine();
            }
        }

        private static void PrintArray(int[][] mas) {
            for (int i = 0; i < mas.Length; i++){
                for (int j = 0; j < mas[i].Length; j++)
                    Console.Write($"{mas[i][j]} ");
            Console.WriteLine();
            }
        }
        static void Main(string[] args){
            int[][] mas = InitJuggedArray(3, 4);
            int[,] mas2 = InitArray(3, 4);
            PrintArray(mas);
            Console.WriteLine();
            PrintArray(mas2);
        }
    }
}
//ex13----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        static int factorial(int n){
        if (n == 1)
            return 1;
        return n * factorial(n - 1);

        }
        static void Main(string[] args){
            Console.WriteLine(factorial(5));
        }
    }
}
//ex14----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        static string Reverce(string str){
            if (str.Length == 1)
                return str;
            return str.Substring(str.Length-1, 1) + Reverce(str.Substring(0, str.Length-1));
        }
        static void Main(string[] args){
            Console.WriteLine(Reverce("Hello"));
        }
    }
}
//ex15----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        static void DoSome(){
            int c;
            Console.WriteLine("Enter number to SQRT\nnot number to exit");
            if ( int.TryParse(Console.ReadLine(), out c) ) {
                Console.WriteLine($"sqrt({c})={Math.Sqrt(c)}");
            } else {
                isOver = true;
            }
        }
        static void Main(string[] args){
            while ( !isOver ) {
                DoSome();
            }
        }
    }
}
//ex16----------------------------------------------------------------------------
using System;

namespace l21{
    class Program{
        private static int counter;

        private static void PrintArray(int[] mas) {
            counter++;
            for ( int i = 0; i < mas.Length; i++ )
                Console.Write($"{mas[i]} ");
            Console.WriteLine();
        }
        static void Main(string[] args){
            int[] arr = { 1,3,4,6};
            PrintArray(arr);

            arr[1] = 2;

            PrintArray(arr);
            Console.WriteLine(counter);
        }
    }
}
