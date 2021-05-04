using System;

namespace l21{
    class Program{
        private static void FillRandArray(int[] mas) {
            Random rand = new Random();
            for ( int i = 0; i < mas.Length; i++ ) {
                mas[i] = rand.Next(0, 101);
            }
        }
        private static void PrintArray(int[] mas) {
            for ( int i = 0; i < mas.Length; i++ )
                Console.Write($"{mas[i]} ");
            Console.WriteLine();
        }
        static void CocktailSort(int size, int[] array){
            for (int i = 0; i < size / 2; i++){
                bool swapped = false;
                for (int j = i; j < size - i - 1; j++){
                    if (array[j] < array[j + 1]){
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                        swapped = true;
                    }
                }
                for (int j = size - 2 - i; j > i; j--){
                    if (array[j] > array[j - 1]){
                        int tmp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tmp;
                        swapped = true;
                    }
                }
                if (!swapped) { break; }
            }
        }
        static void Main(string[] args){
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            Console.Write("Array before sorting: ");
            FillRandArray(array);
            PrintArray(array);
            CocktailSort(size, array);
            Console.Write("Array after sorting: ");
            PrintArray(array);
        }
    }
}
