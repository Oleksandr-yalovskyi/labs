//ex1-------------------------------------------------------
using System;

namespace l22{
    class Program{
        static void Main(string[] args){
            try{
                double x = 1 / new Random().Next(0, 6);
                Console.WriteLine($"{x}");
            } catch {
                Console.WriteLine("Divide By Zero");
            }
        }
    }
}
//ex2-------------------------------------------------------
using System;

namespace l22{
    class Program{
        static void Main(string[] args){
            Random random = new Random();
            int[] arr = new int[random.Next(10)];
            int[] mas = new int[random.Next(10)];

            try{
                arr[random.Next(10)] = random.Next(10);
                Array.Copy(arr, mas, 5);
            } 
            catch (IndexOutOfRangeException) {
                Console.WriteLine("Out of range");
            }
            catch (ArgumentException){
                Console.WriteLine("Can't copy arr to mas");
            }
        }
    }
}
//ex3-------------------------------------------------------
using System;

namespace l22{
    class Program{
        static void PrintArray(int[] arr){
            for (int i = 0; i < arr.GetLength(0); i++){
                Console.Write($"{arr[i]}, ");
            }
        }
        static void Main(string[] args){
            Random random = new Random();
            int[] arr = new int[random.Next(10)];
            int[] mas = new int[random.Next(10)];

            try{
                arr[random.Next(10)] = random.Next(10);
                mas[0] = random.Next(10);
                int a = arr[0] / mas[0];
                Array.Copy(arr, mas, 5);
                mas[0] = a;
            }
            catch (IndexOutOfRangeException){
                Console.WriteLine("Out of range");
            }
            catch (ArgumentException){
                Console.WriteLine("Can't copy arr to mas");
            }
            catch{
                Console.WriteLine("Some other exception");
            }
            PrintArray(mas);
            Console.WriteLine("The end!");
        }
    }
}
//ex4-------------------------------------------------------
using System;

namespace l22{
    class Program{
        static void PrintArray(int[] arr){
            for (int i = 0; i < arr.GetLength(0); i++){
                Console.Write($"{arr[i]}, ");
            }
        }
        static void Main(string[] args){
            Random random = new Random();
            int[] arr = new int[random.Next(10)];
            int[] mas = new int[random.Next(10)];
            try{
                arr[random.Next(10)] = random.Next(10);
                mas[0] = random.Next(10);
                int a = arr[0] / mas[0];
                Array.Copy(arr, mas, 5);
                mas[0] = a;
            }
            catch (IndexOutOfRangeException e){
                Console.WriteLine("Out of range");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e){
                Console.WriteLine("Can't copy arr to mas");
                Console.WriteLine(e.Message);
            }
            catch (Exception e){
                Console.WriteLine("Some other exception");
                Console.WriteLine(e.Message);
            }
            PrintArray(mas);
        }
    }
}
//ex5-------------------------------------------------------
using System;

namespace l22{
    class Program{
        static void PrintArray(int[] arr){
            for (int i = 0; i < arr.GetLength(0); i++){
                Console.Write($"{arr[i]}, ");
            }
        }
        static void Main(string[] args){
            Random random = new Random();
            int[] arr = new int[random.Next(10)];
            int[] mas = new int[random.Next(10)];
            try{
                arr[random.Next(10)] = random.Next(10);
                mas[0] = random.Next(10);
                int a = arr[0] / mas[0];
                Array.Copy(arr, mas, 5);
                mas[0] = a;
            }
            catch (IndexOutOfRangeException e){
                Console.WriteLine("Out of range", e.Message);
            }
            catch (ArgumentException e){
                Console.WriteLine("Can't copy arr to mas", e.Message);
            }
            catch (Exception e) when (mas[0] == 0){
                Console.WriteLine("Divition By Zero", e.Message);
            }
            catch (Exception e){
                Console.WriteLine("Some other exception", e.Message);
            }
            PrintArray(mas);
        }
    }
}
//ex6-------------------------------------------------------
using System;
using System.IO;

namespace l22{
    class Program{
        static void Main(string[] args){
            FileStream stream = null;
            try{
                stream = new FileStream("d://lab22//1.txt", FileMode.Open);
                int b;
                while ((b = stream.ReadByte()) != -1){
                    Console.Write((char)b);
                }
            }
            finally{
                if (stream != null){
                    stream.Close();
                }
            }
        }
    }
}
//ex7-------------------------------------------------------
using System;

namespace l22{
    class Program{
        static void Main(string[] args){
            int[] masA = new int[3];
            double c;
            try{
                int i = Convert.ToInt32(Console.ReadLine());
                int a = Convert.ToInt32(Console.ReadLine());
                masA[i] = a;
                c = 1 / masA[i];
            }
            catch (FormatException){
                Console.WriteLine("Format Exception");
            }
            catch (DivideByZeroException){
                Console.WriteLine("Divide By Zero Exception");
            }
            catch (IndexOutOfRangeException){
                Console.WriteLine("Index Out Of Range Exception");
            }
            catch (OverflowException){
                Console.WriteLine("Overflow Exception");
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
//ex8-------------------------------------------------------
using System;

namespace l22{
    class Program{
        static void Main(string[] args){
            private static void Main(string[] args){
                Console.WriteLine("Enter number for x value:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number for y value:");
                int y = int.Parse(Console.ReadLine());
                try{
                    Console.WriteLine(MyDiv(x, y));
                }
                catch (Exception e){
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
            private static double MyDiv(int a, int b){
                if (b == 0)
                    throw new Exception("Division by zero");
                return (double)a / b;
            }
        }
    }
}
//ex9-------------------------------------------------------
using System;

namespace l22{
    class Program{
        static void Del(int x, int y){
            try{
                int result = x / y;
            }
            catch (DivideByZeroException e){
                Console.WriteLine("Divide By Zero");
                throw e;
            }
        }
        static void Main(){
            try{
                Del(5, 0);
            }
            catch (Exception e){
                Console.WriteLine($"Program error: {e.Message}");
            }
            Console.ReadLine();
        }
    }
