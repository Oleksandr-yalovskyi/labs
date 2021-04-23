using System;

namespace sr1{
    class Program{
        static void Swap(ref int e1, ref int e2){
		var temp = e1;
		e1 = e2;
		e2 = temp;
		}

		static int[] BubbleSort(int[] array){
			var len = array.Length;

			for (var i = 1; i < len; i++){
				for (var j = 0; j < len - i; j++){
					if (array[j] > array[j + 1]){
					Swap(ref array[j], ref array[j + 1]);
					}
				}
			}
			return array;
		}

		static void Main(string[] args){
			Console.WriteLine("Сортування бульбашкою");
			Console.Write("Введiть елементи масиву: ");

			var parts = Console.ReadLine().Split(new[] { " ", ",", ";"}, StringSplitOptions.RemoveEmptyEntries);
			var array = new int[parts.Length];
			for (int i = 0; i < parts.Length; i++){
				array[i] = Convert.ToInt32(parts[i]);
			}

			Console.WriteLine("Вiдсортований масив: {0}",
			string.Join(", ", BubbleSort(array)));
		}
    }
}
//----------------------------------------------------------------------------------------------------------------
using System;

namespace sr1{
    class Program{
        static int IndexOfMin(int[] array, int n){
			int result = n;

			for (var i = n; i < array.Length; ++i) {
				if (array[i] < array[result]){
					result = i;
				}
			}
			return result;
		}
		
		static void Swap(ref int x, ref int y){
			var t = x;

			x = y;
			y = t;
		}

		static int[] SelectionSort(int[] array, int currentIndex = 0){
			if (currentIndex == array.Length) {return array;}

			var index = IndexOfMin(array, currentIndex);

			if (index != currentIndex){
				Swap(ref array[index], ref array[currentIndex]);
			}
			return SelectionSort(array, currentIndex + 1);
		}

		static void Main(string[] args){
			Console.WriteLine("Сортування вибором");

			Console.Write("Введiть елементи масиву: ");

			var s = Console.ReadLine().Split(new[] { " ", ",", ";"}, StringSplitOptions.RemoveEmptyEntries);
			var a = new int[s.Length];

			for (int i = 0; i < s.Length; i++){
				a[i] = Convert.ToInt32(s[i]);
			}

			Console.WriteLine("Впорядкований масив: {0}", string.Join(", ", SelectionSort(a)));
		}
	}
}
//----------------------------------------------------------------------------------------------------------------
using System;

namespace sr1{
    class Program{
        static void Swap(ref int e1, ref int e2){
			var temp = e1;
			e1 = e2;
			e2 = temp;
		}
		static int[] InsertionSort(int[] array){
			for (var i = 1; i < array.Length; i++){
				var key = array[i];
				var j = i;

				while ((j > 1) && (array[j - 1] > key)){
					Swap(ref array[j - 1], ref array[j]);
					j--;
				}

				array[j] = key;
			}
			return array;
		}
		static void Main(string[] args){
			Console.WriteLine("Сортування включенням");
			Console.Write("Введiть елементи масиву: ");

			var parts = Console.ReadLine().Split(new[] { " ", ",",";" }, StringSplitOptions.RemoveEmptyEntries);
			var array = new int[parts.Length];

			for (int i = 0; i < parts.Length; i++){
				array[i] = Convert.ToInt32(parts[i]);
			}

			Console.WriteLine("Впорядкований масив: {0}",

			string.Join(", ", InsertionSort(array)));
		}
	}
}
//----------------------------------------------------------------------------------------------------------------
using System;

namespace sr1{
    class Program{
        static void Main(string[] args){
			string[] daysOfWeek = { "Sunday", "Monday", "Tuersday","Wednesday", "Thirsday", "Friday", "Saturday" };
		    for (int i = 0; i < daysOfWeek.Length; i++){
				Console.WriteLine("AS[{0}] = {1}", i, daysOfWeek[i]);
			}
		}
	}
}
//----------------------------------------------------------------------------------------------------------------
using System;

namespace sr1{
    class Program{
        static void Main(string[] args){
			string[] AS;
			int count;
			string s;
			string[] AS2;

			Console.WriteLine("Enter strings:");
			count = 0;
			AS = new string[count];
			do{
				s = Console.ReadLine();
				if (s != ""){
					count++;
					AS2 = new string[count];
					for (int i = 0; i < AS2.Length - 1; i++){
						AS2[i] = AS[i];
					}
					
					AS2[count - 1] = s;
					AS = AS2;
				}
			} while (s != "");
			
			for (int i = 0; i < AS.Length; i++){
				Console.WriteLine("AS[{0}] = {1}", i, AS[i]);
				Console.ReadKey();
			}
		}
	}
}
//----------------------------------------------------------------------------------------------------------------
using System;

namespace sr1{
    class Program{
        static void Main(string[] args){
			string[] AS;
			int count;
			string s;

			Console.Write("count = ");

			count = Int32.Parse(Console.ReadLine());

			AS = new string[count];

			Console.WriteLine("Enter array:");
			for (int i = 0; i < AS.Length; i++){
				Console.Write("AS[{0}] = ", i);
				AS[i] = Console.ReadLine();
			}

			for (int i = 0; i < AS.Length - 1; i++)
			for (int j = i; j >= 0; j--)
			if (String.Compare(AS[j], AS[j + 1]) > 0) {
				s = AS[j];

				AS[j] = AS[j + 1];
				AS[j + 1] = s;
			}

			Console.WriteLine("Sorted array:");
			for (int i = 0; i < AS.Length; i++) {
				Console.WriteLine("AS[{0}] = {1}", i, AS[i]);
			}
		}
	}
}
//----------------------------------------------------------------------------------------------------------------
using System;

namespace sr1{
    class Program{
        static void Main(string[] args){
			string[] AS;
			int count;
			string str;

			Console.Write("count = ");
			count = Int32.Parse(Console.ReadLine());
			
			if (count <= 0){
				Console.WriteLine("Error. The value of count is incorrect.");
				Console.ReadKey();
				return;
			}
			
			AS = new string[count];
			
			Console.WriteLine("Enter array:");
			for (int i = 0; i < AS.Length; i++){
				Console.Write("AS[{0}] = ", i);
				AS[i] = Console.ReadLine();
			}
			
			Console.Write("Enter string: ");
			str = Console.ReadLine();
			
			bool f_is = false;
			int index = -1;

			for (int i = 0; i < AS.Length - 1; i++)
			if (str == AS[i]){
				f_is = true;
				index = i;
			}
			
			if (f_is){
				Console.WriteLine("String \"{0}\" is in the array.", str);
				Console.WriteLine("Position is {0}", index);
			} else {
				Console.WriteLine("String \"{0}\" is not in the array.", str);
			}
		}
	}
}
//----------------------------------------------------------------------------------------------------------------
using System;

namespace sr1{
    class Program{
        static void Main(string[] args){
			string[] AS;
			int count;
			string str;
			int n_occurs;
		
			Console.WriteLine("Enter string:");
			str = Console.ReadLine();
		
			Console.Write("count = ");
			count = Convert.ToInt32(Console.ReadLine());
	
			if (count <= 0){
				Console.WriteLine("Error. The value of count is incorrect.");
				Console.ReadLine();
				return;
			}
		
			AS = new string[count];
			
			Console.WriteLine("Enter the array AS:");
			for (int i=0; i < AS.Length; i++){
				Console.Write("AS[{0}] = ", i);
				AS[i] = Console.ReadLine();
			}
			
			n_occurs = 0;
			for (int i = 0; i < AS.Length; i++)
			if (str == AS[i])
				n_occurs++;
			
			Console.WriteLine("n_occurs = {0}", n_occurs);
		}
	}
}
