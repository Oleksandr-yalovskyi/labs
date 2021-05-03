using System;

namespace l21{
    class Program{
        static string[] AddN(int a, params string[] rows){
            for ( int i = 0; i < rows.Length; i++ ) {
                rows[i] = (i+a).ToString() + ". " + rows[i];
            }
            return rows;
        }
        static void Main(string[] args){
            string[] array = new string[3];
            Console.WriteLine("Enter first number: ");
            string sa = Console.ReadLine();
            int a = int.Parse(sa);

            for ( int i = 0; i < array.Length; i++ ) {
                Console.WriteLine($"Enter string number {i+1}");
                string sr = Console.ReadLine();
                array[i] = sr;
            }
                 
            Console.WriteLine(string.Join("\n", AddN(a, array)));
        }
    }
}
