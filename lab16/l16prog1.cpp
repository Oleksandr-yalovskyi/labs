#include <iostream>
using namespace std;

class Complex {
private:
    double real;
    double imaginary;
public:
    Complex(double real = 0, double imaginary = 0);
    ~Complex();

    void operator+=(const Complex& other);
    void operator-=(const Complex& other);
    Complex operator+(const Complex& other) const;
    Complex operator-(const Complex& other) const;

    void print();
    void read();
    void printj();
};

Complex::Complex(double real, double imaginary) {
    this->real = real;
    this->imaginary = imaginary;
}

Complex::~Complex() {}

Complex Complex::operator+(const Complex& other) const {
    Complex result = *this;
    result.real += other.real;
    result.imaginary += other.imaginary;
    return result;
}

void Complex::operator+=(const Complex& other) {
    real += other.real;
    imaginary += other.imaginary;
}


Complex Complex::operator-(const Complex& other) const {
    Complex result = *this;
    result.real -= other.real;
    result.imaginary -= other.imaginary;
    return result;
}

void Complex::operator-=(const Complex& other) {
    real -= other.real;
    imaginary -= other.imaginary;
}


void Complex::print() {
    cout << "(" << real << "," << imaginary << ")" << endl;
}

void Complex::read() {
    cout << "Set real part: ";
    cin >> real;
    cout << "Set imaginary part: ";
    cin >> imaginary;
}

void Complex::printj() {
    cout << real << " + " << imaginary << " * j, j = (-1)^0.5" << endl;
}

int main() {
    Complex complex1(2, 3), complex2, complex3;
    cout << "complex1 = ";
  	complex1.print();

    complex2.read();

    cout << endl << "complex2 = ";
    complex2.print();
    complex2 += complex1;
    cout << endl << "complex2 = ";
    complex2.print();

    complex3 = complex1 + complex2;

    complex3.printj();

    return 0;
}
