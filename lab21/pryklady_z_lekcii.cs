//ex1----------------------------------------------------------
using System;

namespace l21{
    class Program{
        static void PrintHelloWorld(){
            Console.WriteLine("Hello World!");
        }
        static void PrintHello(string name){
            var text = " Hello " + name + " !" ;
            Console.WriteLine(text);
        }
        static int Cube(int x){
            return x * x * x;
        }
        static void Main(string[] args){
            PrintHelloWorld();
            PrintHello(" Andrew ");
            var b1 = Cube(2);
            var b2 = Cube(3);
        }
    }
}
//ex2----------------------------------------------------------
using System;

namespace l21{
    class Program{
        static int Add(int x1, int x2){
            x1 += x2;
            return x1;
        }
        static void Main(string[] args){
            var num1 = 2;
            var num2 = 5;
            var sum = Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {sum}");
        }
    }
}
//ex3----------------------------------------------------------
using System;

namespace l21{
    class Program{
        static int Mult(ref int x1, int x2){
            x1 *= x2;
            return x1;
        }
        static void Main(string[] args){
            var n1 = 24;
            var n2 = 4;
            var mult = Mult(ref n1, n2);

            Console.WriteLine($"{n1}");
        }
    }
}
//ex4----------------------------------------------------------
using System;

namespace l21{
    class Program{
        static string Div(int a, int b, out int result){
                if (b == 0){
                    result = int.MinValue;
                    return " На нуль ділити не можна! ";
                }else{
                result = a / b;
                return " ";
            }
        }
        static void PrintResult(string errorText, int res){
            if (string.IsNullOrEmpty(errorText)){
                Console.WriteLine(res);
            }else{
                Console.WriteLine(errorText);
            }
        }
        static void Main(string[] args){
            int r1;
            var err1 = Div(64, 8, out r1);
            PrintResult(err1, r1);
            var err2 = Div(34, 0, out int r2);
            PrintResult(err2, r2);
        }
    }
}
//ex5----------------------------------------------------------
using System;

namespace l21{
    class Program{
        static int ArrayMax(int[] array){
            var maxValue = int.MinValue;
            foreach (var element in array){
                if (maxValue < element){
                    maxValue = element;
                }
            }
            return maxValue;
        }
        static void Main(string[] args){
            var a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($" Максимальне значення масиву {ArrayMax(a)}");
        }
    }
}
//ex6----------------------------------------------------------
using System;

namespace l21{
    class Program{
        static void ChangeToAbs(int[] arr){
            for (var i = 0; i < arr.Length; i++){
                if (arr[i] < 0){
                    arr[i] *= -1;
                }
            }
        }
        static void Main(string[] args){
            var a = new[] { -2, 5, 7, 3, -9, -6, 0, -1 };
            ChangeToAbs(a);
            Console.WriteLine(string.Join(", ", a));
        }
    }
}
//ex7----------------------------------------------------------
using System;

namespace l21{
    class Program{
		static float Minimal(params float[] values){
			var min = float.MaxValue;
			for (var i = 0; i < values.Length; i++){
				if (min > values[i]){
					min = values[i];
				}
			}
			return min;
}
		static void Main(string[] args){
			Console.WriteLine(Minimal());
			Console.WriteLine(Minimal(2, 5));
			Console.WriteLine(Minimal(6, 5, 4, 3, 1));
			Console.WriteLine(Minimal(new[] { 5f, 9f }));
		}
    }
}
//ex8----------------------------------------------------------
using System;

class Program{
	static ulong Factorial(uint n){
		return n == 0 ? 1 : Factorial(n - 1) * n;
	}

	static void Main(string[] args){
		Console.Write("n = ");
		var n = Convert.ToUInt32(Console.ReadLine());
		Console.WriteLine($"Факторіал числа {n} рівний {Factorial(n)}");
	}
}
//ex9----------------------------------------------------------
using System;

class Program{
	static uint FibonacciNum(uint n){
		return (n == 0 || n == 1) ? 1 : FibonacciNum(n - 1) + FibonacciNum(n - 2);
	}
	static void Main(string[] args){
		Console.Write("N = ");
		var n = Convert.ToUInt32(Console.ReadLine());
		Console.WriteLine($"{n} перших чисел Фiбоначчi");
		for (uint i = 0; i < n; i++){
			var separator = i + 1 == n ? string.Empty : ", ";
			Console.Write($"{FibonacciNum(i)}{separator}");
		}
	}
}
//ex10---------------------------------------------------------
using System;

namespace l21{
    class Program{
		static uint[] FibonacciNumbers(uint n) {
			uint[] arr = new uint[n];
			n -= 1;

			if (n == 0){
				arr[0] = 1;
			} else {
				arr[0] = 1;
				arr[1] = 1;
			}
			for (int i = 2; i <= n; i++){
				arr[i] = arr[i - 1] + arr[i - 2];
			}
			return arr;
		}

		static void Main(string[] args){
			Console.Write("N = ");
			var n = Convert.ToUInt32(Console.ReadLine());
			Console.WriteLine($"{n} перших чисел послiдовностi Фiбоначчi");
			Console.WriteLine(string.Join(", ", FibonacciNumbers(n)));
		}
    }
}
