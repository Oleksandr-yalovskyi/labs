using System;

namespace l21{
    class Program{
        static uint Mul(uint a, uint b) => a * b + 1;
        static int Mul(int a, int b) => a * b + 2;
        static long Mul(long a, long b) => a * b + 3;
        
        static void Main(string[] args){
        Console.WriteLine($"uint 2*3 = {Mul(2U, 3U)}");
        Console.WriteLine($"int  2*3 = {Mul(2, 3)}");
        Console.WriteLine($"long 2*3 = {Mul(2L, 3L)}");
        }
    }
}
