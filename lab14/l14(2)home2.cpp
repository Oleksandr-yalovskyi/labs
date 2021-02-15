#include <iostream>
using namespace std;

int powerOf(int num, int power) {
    if ( power > 0 ) {
        return num * powerOf(num, power-1);
    } else {
        return 1;
    }
}

int main() {
	int num, power;

	cout << "Enter your number: ";
	cin >> num;
	cout << "Enter power of number: ";
	cin >> power;

	cout << powerOf(num, power) << endl;

	return 0;
}
