#include <iostream>
using namespace std;

class Array { // створення класу 
	private: // ініціалізація недоступних змінних
		int capacity;
		int* array;
	public: // функції та методи
		Array(); // конструктор
		~Array(); // деструктор

		// функції для роботи з масивом
		void setCapacity(); // встановлення розміру масиву
		void find(); // пошук по індексу
		void arrayPrint(); // вивід масиву на екран
		void arrayScan(); // ввід масиву вручну
		void result(); // завдання з варіанту

		// перенавантаження операторів
		void operator+=(const Array& other);
		void operator-=(const Array & other);
		void operator*=(const Array& other);
};

Array::Array() { // створення масиву у конструкторі
	capacity = 100;
	array = new int[capacity];
	for (int i = 0; i < capacity; i++) {
		array[i] = rand() % 11 - 5;
	}
}

Array::~Array() { // видалення масиву
	delete[] array;
}

void Array::arrayPrint() {
	for (int i = 0; i < capacity; i++) {
		cout << *(array + i) << " ";
	}
	cout << endl;
}

void Array::arrayScan() {
	for (int i = 0; i < capacity; i++) {
		cin >> *(array + i);
	}
}

void Array::setCapacity() {
	cout << "Enter your capacity: "
	cin >> capacity;
}

void Array::result() {
	for (int i = 0; i < capacity; i++) {
		if (*(array + i) > 0) {
			if (*(array + i) % 2 == 0) {
				*(array + i) *= 3;
			}
		}
	}
}

void Array::find() {
	int value;
	cout << "Enter number index: ";
	cin >> value;

	for (int i = 0; i < capacity; i++) {
		if ( i == value ) {
			cout << *(array + i) << endl;
		}
	}
}

void Array::operator+=(const Array& other) {
	for ( int i = 0; i < capacity; i++ ) {
		array[i] += other.array[i];
	}
}

void Array::operator-=(const Array& other) {
	for (int i = 0; i < capacity; i++) {
		array[i] -= other.array[i];
	}
}

void Array::operator*=(const Array& other) {
	for (int i = 0; i < capacity; i++) {
		array[i] *= other.array[i];
	}
}

int main() {
	Array array1, array2; // ініціалізація двох масивів

	// перевірка роботи функцій
	array1.setCapacity();
	array1.arrayPrint();
	array1.result();
	array1.find();

	array2.setCapacity();
	array2.arrayScan();
	array2.arrayPrint();

	array1 += array2;
	array1.arrayPrint();
	array1 -= array2;
	array1.arrayPrint();
	array1 *= array2;
	array1.arrayPrint();

	return 0;
}
