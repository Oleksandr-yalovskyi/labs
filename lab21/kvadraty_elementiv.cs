using System;

namespace l21{
    class Program{
        static int[] PowOf2(params int[] nums){
            for (int i = 0; i < nums.Length; i++){
                nums[i] *= nums[i];
            }
            return nums;
        }
        static void Main(string[] args){
            Console.WriteLine(string.Join(", ", PowOf2(1,2,3)));
        }
    }
}
