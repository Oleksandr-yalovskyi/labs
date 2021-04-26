using System;

namespace l20{
    class Program{
        static void Main(string[] args){
	        string input = Console.ReadLine();
          int mid = input.Length / 2;

          Console.WriteLine($"First symbol = {input[0]}, Middle symbol = {input[mid]}, Last symbol = {input[input.Length - 1]}");
		    }
    }
}
