#include <iostream>
using namespace std;

class Rational {
private:
	int a;
	int b;
public:
	Rational(int a = 1, int b = 1);
	~Rational();
	Rational operator+(const Rational& other) const;
	Rational operator-(const Rational& other) const;
	Rational operator*(const Rational& other) const;
	Rational operator/(const Rational& other) const;

	void print();
	void printDec();
	void read();

	int gcd(int a, int b);
};

Rational::Rational(int a, int b) {
	int reduce = gcd(a, b);
	this->a = a / reduce;
	this->b = b / reduce;
}

Rational::~Rational() {}

Rational Rational::operator+(const Rational& other) const {
	Rational result = *this;
	result.a = a * other.b + other.a * b;
	result.b *= other.b;
	return result;
}

Rational Rational::operator-(const Rational& other) const {
	Rational result = *this;
	result.a = a * other.b - other.a * b;
	result.b *= other.b;
	return result;
}

Rational Rational::operator*(const Rational& other) const {
	Rational result = *this;
	result.a *= other.a;
	result.b *= other.b;
	return result;
}

Rational Rational::operator/(const Rational& other) const {
	Rational result = *this;
	result.a *= other.b;
	result.b *= other.a;
	return result;
}

void Rational::print() {
	int n = a, d = b;
	a /= gcd(n, d);
	b /= gcd(n, d);
	
	cout << a << "/" << b << endl;
}

void Rational::read() {
	cout << "Set numerator: ";
	cin >> a;
	cout << "Set denumerator: ";
	cin >> b;
}

void Rational::printDec() {
	double n = a, d = b;
	cout << a << "/" << b << " = " << n / d << endl;
}

int Rational::gcd(int n, int d) {
	if (n < 0) { n *= -1; }
	if (d < 0) { d *= -1; }
	while (d > 0) {
		int c = n % d;
		n = d;
		d = c;
	}
	return n;
}

int main() {
	Rational rational1(4, 28), rational2, sum, dif, mul, divis;
	cout << "rational1 = "; rational1.print();
	rational2.read();
	cout << "rational2 = "; rational2.print();

	sum = rational1 + rational2;
	dif = rational1 - rational2;
	mul = rational1 * rational2;
	divis = rational1 / rational2;
	cout << "Sum: "; sum.printDec();
	cout << "Dif: "; dif.print();
	cout << "Mul: "; mul.printDec();
	cout << "Div: "; divis.print();

	return 0;
}
