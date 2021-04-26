using System;

namespace l20{
    class Program{
        static void Main(string[] args){
          string input = Console.ReadKey();
          string output = "";

          for ( int i = input.Length - 1; i >= 0; i-- ) {
            output += input[i];
          }

          Console.WriteLine($"Reversed string = {output}");
		  }
    }
}
