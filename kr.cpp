#include <iostream>
using namespace std;

class Array {
private:
	int capacity;
	int* array;
public:
	Array();
	~Array();

	void getCapacity();
	void find();
	void arrayPrint();
	void arrayScan();
	void result();

	void operator+=(const Array& other);
	void operator-=(const Array & other);
	void operator*=(const Array& other);
};

Array::Array() {
	capacity = 100;
	array = new int[capacity];
	for (int i = 0; i < capacity; i++) {
		array[i] = rand() % 11 - 5;
	}
}

Array::~Array() {
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

void Array::getCapacity() {
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
	Array array1, array2;
	array1.getCapacity();
	array1.arrayPrint();
	array1.result();
	array1.find();

	array2.getCapacity();
	array2.arrayPrint();
	array2.result();
	array2.find();

	array1 += array2;
	array1.arrayPrint();
	array1 -= array2;
	array1.arrayPrint();
	array1 *= array2;
	array1.arrayPrint();

	return 0;
}
