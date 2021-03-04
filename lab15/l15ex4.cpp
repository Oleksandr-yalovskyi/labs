#include <iostream>
using namespace std;

struct cars{
	char model[15];
	int price;
};

cars INPUT_cars() {
	cars car1;
	cout << "INPUT model: ";
	cin >> car1.model;
	cout << "INPUT price: ";
	cin >> car1.price;
	return car1;
}

void OUTPUT_cars(cars car) {
	cout << endl << "MODEL: " << car.model << endl;
	cout << "PRICE: " << car.price << endl;
	cout << "_____________" << endl;
}

int main() {
	cars A1;

	A1 = INPUT_cars();

	OUTPUT_cars(A1);

	cout << "Size of A1 = " << sizeof(A1) << endl;

	system("pause");

	return 0;
}
