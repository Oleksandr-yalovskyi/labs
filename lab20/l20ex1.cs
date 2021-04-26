using System;

namespace l20{
    class Program{
        static void Main(string[] args){
          string s1 = "Hello";
          Console.WriteLine("s1 = {0}", s1);

          char[] ArrayChar = { 'H', 'e', 'l', 'l', 'o' };
          string s2 = new string(ArrayChar);
          Console.WriteLine("s2 = {0}", s2);

          string s3 = new string(ArrayChar, 2, 3);
          Console.WriteLine("s3 = {0}", s3);

          string s4;
          s4 = "Hello";
          Console.WriteLine("s4 = {0}", s4);

          string s5 = new string('+', 10);
          Console.WriteLine("s5 = {0}", s5);

          string s6;
          s6 = @"C:\Programs\abc.txt";
          Console.WriteLine("s6 = {0}", s6);
		  }
    }
}
