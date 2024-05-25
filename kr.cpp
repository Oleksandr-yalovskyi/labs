#include <iostream>
using namespace std;

class Array { // create a class
    private: // initialize inaccessible variables
        int capacity;
        int* array;
    public: // functions and methods
        Array(); // constructor
        ~Array(); // destructor

        // functions for working with the array
        void setCapacity(); // set the size of the array
        void find(); // search by index
        void arrayPrint(); // print the array to the screen
        void arrayScan(); // manually input the array
        void result(); // task from the variant

        // operator overloading
        void operator+=(const Array& other);
        void operator-=(const Array & other);
        void operator*=(const Array& other);
};

Array::Array() { // create the array in the constructor
    capacity = 100;
    array = new int[capacity];
    for (int i = 0; i < capacity; i++) {
        array[i] = rand() % 11 - 5;
    }
}

Array::~Array() { // delete the array
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
    cout << "Enter your capacity: ";
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
    Array array1, array2; // initialize two arrays

    // check the functions
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
