#include <iostream.h>
#include <conio.h>
#pragma hdrstop

int multiply(int, int);

void showResult(int);

int main() {
	int x, y, result;
	cout << endl << "Enter the first value: ";
	cin >> x;
	cout << "Enter the second value: ";
	cin >> y;
	result = multiply(x, y);
	showResult(result);
	cout << endl << endl << "Press any key to continue...";
	getch();

	return 0;
}

int multiply(int x, int y) { return x * y; }

void showResult(int res){ 
	cout << "The result is: " << res << endl; 
}
