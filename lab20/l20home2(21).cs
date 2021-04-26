using System;

namespace l20{
    class Program{
        static void Main(string[] args){
        	Console.WriteLine("Enter text: ");
	        string input = Console.ReadLine();
	        int n, k; 
	        int max = 0;
	        int i = 0;

	        while ( i < input.Length ) {
	        	if ( input[i] >= 47 && input[i] <= 57 ) {
	        		n = i;
	        		k = 1;
	        		while ( input[n+k] >= 47 && input[n+k] <= 57 ) {
	        			k++;
	        			if ( k > max ) {
	        				max = k;
	        			}
	        		}
	        		i = i + k + 1;
	        	} else {
	        		i++;
	        	}
	        }

	        Console.WriteLine($"largest number of consecutive digits = {max}");
		}
    }
}
