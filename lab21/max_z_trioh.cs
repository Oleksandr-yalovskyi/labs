using System;

namespace l21{
    class Program{
        static float Max(float a, float b){
            if ( a > b ) {
                return a;
            } else {
                return b;
            }
        }
        static float Max(float a, float b, float c){
            float max = Max(a, b);
            if ( c > max ) {
                return c;
            } else {
                return max;
            }
        }
        static void Main(string[] args){
            Console.Write("Enter first number: ");
            var f1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter second number: ");
            var f2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter third number: ");
            var f3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Max number: {Max(f1, f2, f3)}");
        }
    }
}
