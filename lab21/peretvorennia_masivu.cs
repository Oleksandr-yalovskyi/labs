using System;

namespace l21{
    class Program{
        static float[] Mult(float a, params float[] nums){
            for ( int i = 0; i < nums.Length; i++ ) {
                if ( nums[i] < 0 ) {
                    nums[i] *= a;
                }
            }
            return nums;
        }
        static void Main(string[] args){
            float[] array = new float[5];
            string sa = Console.ReadLine();
            float a = float.Parse(sa);

            for ( int i = 0; i < array.Length; i++ ) {
                string sr = Console.ReadLine();
                array[i] = float.Parse(sr);
            }
                 
            Console.WriteLine(string.Join(", ", Mult(a, array)));
        }
    }
}
