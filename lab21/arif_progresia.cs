using System;

namespace l21{
    class Program{
        static int Progression(int n){
            if ( n == 0 ) {
                return 1;
            } 
            return Progression(n - 1) + 1;
        }

        static void Main(string[] args){
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for ( int i = 0; i < n; i++ ) {
                Console.WriteLine(Progression(i));
            }
        }
    }
}
