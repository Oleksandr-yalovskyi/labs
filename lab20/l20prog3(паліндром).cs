using System;

namespace l20{
    class Program{
        static void Main(string[] args){
	        string input = Console.ReadLine();
			string output;

	        string s = input.Replace(" ", string.Empty);
	        s = s.ToLower();
	        int LastIndex = s.Length - 1;
	        for ( int i = 0; i < s.Length / 2; i++ ) {
	        	if ( s[i] != s[LastIndex - i] ) {
	        		Console.WriteLine("String isn't a palindrom");
	        	} else {
	        		Console.WriteLine("String is a palindrom");
	        	}
	       	}
	}
    }
}
