using System;

namespace l20{
    class Program{
        static void Main(string[] args){
	        string input = Console.ReadLine();
			string output;

	        var parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
	        for (int i = 0; i < parts.Length; i++){
	            var firstLetter = parts[i].Substring(0, 1).ToUpper();
	            
	            parts[i] = firstLetter + parts[i].Remove(0, 1);
	        }

	        output = string.Join(" ", parts);
	        Console.WriteLine($"After capitalization: {output}");
		}
    }
}
