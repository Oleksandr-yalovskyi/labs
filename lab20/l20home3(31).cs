using System;

namespace l20{
    class Program{
        static void Main(string[] args){
        	string s = Console.ReadLine();
            int a = s.IndexOf("@");
            int b = s.IndexOf(".");
            int c = s.LastIndexOf(".");
            if ( a == -1 || b == -1 || s.Length - c < 2 ) {
                Console.WriteLine("Incorrect Email");
            } else {
                Console.WriteLine("Correct Email");
            }
		    }
    }
}
