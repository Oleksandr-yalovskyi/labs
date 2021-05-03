using System;

namespace l21{
    class Program{
        static int Progression(int n, int d){
            if ( n == 0 ) {
                return d;
            } 
            return Progression(n - 1, d) + d;
        }

        static void Main(string[] args){
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for ( int i = 0; i < n; i++ ) {
                sum += Progression(i, d);
            }

            Console.WriteLine($"The sum of the arithmetic progression = {sum}");
        }
    }
}
