//ex1--------------------------------------------------------------------------
using System;

namespace l22{
    class Program{
        static void Main(string[] args){
            try{
			int a = int.Parse(args[0]);
			int b = int.Parse(args[1]);

			Console.WriteLine($"result: {a}+{b} = {a + b}");
			}

			catch{
				Console.WriteLine("Somethings wrong :(");
			}
        }
    }
}
//ex2--------------------------------------------------------------------------
using System;

namespace l22{
    class Program{
        static void Main(string[] args){
            try{
			int a = int.Parse(args[0]);
			int b = int.Parse(args[1]);

			Console.WriteLine($"result: {a}+{b} = {a + b}");
			}

			catch (FormatException){
				Console.WriteLine("Enter just a number next time!");
			}

			catch (IndexOutOfRangeException){
				Console.WriteLine("You need 2 arguments");
			}

			catch (OverflowException){
				Console.WriteLine("number range in {0:E} - {1:E}", int.MinValue, int.MaxValue);
			}
        }
    }
}
//ex3--------------------------------------------------------------------------
using System;

namespace l22{
    class Program{
        static void Main(string[] args){
            try{
			int a = int.Parse(args[0]);
			int b = int.Parse(args[1]);

			Console.WriteLine($"result: {a}+{b} = {a + b}");

			checked{
				Console.WriteLine($"result: {a}+{b} = {a + b}");
			}

			}
			catch (FormatException){
				Console.WriteLine("Enter just a number next time!");
			}

			catch (IndexOutOfRangeException){
				Console.WriteLine("You need 2 arguments");
			}

			catch (OverflowException){
				Console.WriteLine("number range in {0:E} - {1:E}", int.MinValue, int.MaxValue);
			}
		}
	}
}
//ex4--------------------------------------------------------------------------
using System;

namespace l22{
    class Program{
        static void Main(string[] args){
        	int a = int.MinValue;
			int b = int.MinValue;

            try{
			a = int.Parse(args[0]);
			b = int.Parse(args[1]);

			Console.WriteLine($"result: {a}+{b} = {a + b}");

			checked{
				Console.WriteLine($"result: {a}+{b} = {a + b}");
			}

			}
			catch (FormatException){
				Console.WriteLine("Enter just a number next time!");
			}

			catch (IndexOutOfRangeException){
				Console.WriteLine("You need 2 arguments");
			}

			catch (OverflowException) when (a != int.MinValue && b != Int32.MinValue){
				Console.WriteLine($"result: {a}+{b} = {double.NaN}");
			}

			catch (OverflowException) {
				Console.WriteLine("number range in {0:E} - {1:E}", int.MinValue, int.MaxValue);
			}
		}
	}
}
//ex5--------------------------------------------------------------------------
using System;

namespace l22{
    class Program{
        static void Main(string[] args){
        	Console.WriteLine("Enter number for x value:");
			int x = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter number for y value:");
			int y = int.Parse(Console.ReadLine());

			try{
				Console.WriteLine(MyDiv(x, y));
			}

			catch (Exception e){
				Console.WriteLine(e.Message);
			}
		}
		private static double MyDiv(int a, int b){

		if(b==0)
			throw new Exception("Division by zero");
		return (double)a/b;
		}
	}
}
//ex6
--------------------------------------------------------------------------
using System;

namespace l22{
    class Program{
        static void Main(string[] args){
        	try{
				Del(5, 0);
			}

			catch(Exception e){
				Console.WriteLine($"Program error: {e.Message}");
			}
		}
		static void Del(int x, int y){
			try{
				int result = x / y;
			}

			catch (DivideByZeroException e){
				Console.WriteLine("Divide By Zero");

				throw e;
			}
		}	
	}
}
