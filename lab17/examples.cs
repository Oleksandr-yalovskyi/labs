// 1
using System;

namespace l17 {
	class Program {
		static void Main() {
			string = message = "Hello world!";
			Console.WriteLine(message);

			Console.ReadKey();
		}
	}
}

// 2
using System;

namespace l17{
    class Program{
        static void Main(string[] args){
            int a = 100;
       		int b = 10;
       		int c = a * b;
       		Console.WriteLine($"a * b = {c}");

       		Console.ReadKey();
        }
    }
}

// 3
using System;

namespace l17{
    class Program{
        static void Main(string[] args){
            float f = 1.1f, fs = 1.0f;
            const double pi = 3.14;
            Console.WriteLine("f = {0}; pi = {1}; fs = {2}", f, pi, fs);

            Console.ReadKey();
        }
    }
}

// 4
using System;

namespace l17{
    class Program{
        static void Main(string[] args){
        	char char_literal = 'A';
        	char hexadecimal = '\x0041';
        	char integer = (char)65;
        	char unicode = '\u0041';

        	Console.WriteLine(char_literal + " " + hexadecimal + " " + integer + " " + unicode);
            Console.ReadKey();
        }
    }
}

// 5
using System;

namespace l17{
    class Program{
        static void Main(string[] args){
            bool ba = true;
            bool bb = false;
            bool bc = ba;
            bool bd = !bb;

            Console.WriteLine($"ba = {ba} \n bb = {bb} \n bc = {bc} \n bd = {bd}");

            Console.ReadKey();
        }
    }
}

// 6
using System;

namespace l17{
    class Program{
        static void Main(string[] args){
            string msg;

            msg = "Hello";

            string name = "Vasj";

            Console.WriteLine($"{msg}, {name}");

            Console.ReadKey();
        }
    }
}

// 7
using System;

namespace l17{
    class Program{
        static void Main(string[] args){
            const string MSG = "HELLO";

            string name = "Vasj";
            name = "Petj";

            Console.WriteLine($"{MSG}, {name}");

            Console.ReadKey();
        }
    }
}

// 8
using System;

namespace l17{
    class Program{
        static void Main(string[] args){
        	int a - 1;
        	a = a + 1;
        	Console.WriteLine(a);
        	a += 1;
        	Console.WriteLine(a);
        	a++;
        	Console.WriteLine(a);
        	++a;
        	Console.WriteLine(a);
        	a--;
        	Console.WriteLine(a);
        	--a;
        	Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}

// 9
using System;

namespace l17{
    class Program{
        static void Main(string[] args){
            byte b = 100;
            short s = b;
            int x = s;
            long y = x;
            Console.WriteLine(y);
        }
    }
}

// 10
using System;

namespace l17{
    class Program{
        static void Main(string[] args){
            long l = 2_000_000_000_002l;
            int i = (int)l;
            short s = (short)i;
            byte b = (byte)s;

            Console.WriteLine($"l ={l} \ni = {i} \ns = {s} \nb = {b}");
        }
    }
}

// 11
using System;

namespace l17{
    class Program{
        static void Main(string[] args){
            string x = Console.ReadLine();
            int x1 = int.Parse(x);
            int x2 = Convert.ToInt32(x);
            Console.WriteLine($"x^2 = {x1 * x2}");
        }
    }
}

// 12
using System;

namespace l17{
    class Program{
        static void Main(string[] args){
            string xString = Console.ReadLine();
            int x = Convert.ToInt32(xString);
            int y = (int) Math.Pow(x,2);
            Console.WriteLine($"x^2 = {y}");
            double z = Math.Cos(y);
            Console.WriteLine($"cos(x^2) = {z}");
        }
    }
}

// 13
using System;

namespace l17{
    class Program{
        static void Main(string[] args){
        	int a = 1_003;

        	Console.WriteLine($"a / 10 = {a / 10}");
        	Console.WriteLine($"a % 10 = {a % 10}");
        }
    }
}
