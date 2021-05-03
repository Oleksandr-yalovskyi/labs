using System;

namespace l21{
    class Program{
        static string Reverce(string str){
            if (str.Length == 1)
                return str;
            return str.Substring(str.Length-1, 1) + Reverce(str.Substring(0, str.Length-1));
        }
        static void Main(string[] args){
            Console.Write("Enter string: ");
            string s = Console.ReadLine();
            Console.WriteLine(Reverce(s));
        }
    }
}
