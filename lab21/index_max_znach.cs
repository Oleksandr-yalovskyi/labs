using System;

namespace l21{
    class Program{
        static int IngexOfMax(int[] array, int len){
            if ( len == 0 ) {
                return len;
            }
            int i = IngexOfMax(array, len - 1);
            return array[len] > array[i] ? len : i;
        }
        static void Main(string[] args){
            int[] array = new int[5];

            for ( int i = 0; i < array.Length; i++ ) {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Ingex Of Max: {IndexOfMax(array, array.Length - 1)}");
        }
    }
}
