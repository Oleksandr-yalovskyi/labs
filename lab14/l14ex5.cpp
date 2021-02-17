#include <iostream>
#include <conio.h>
#include <iomanip>
#pragma hdrstop
using namespace std;

int Fib(int);

int main(int argc, char** argv){
	int n;

	cout << endl << "Enter n: ";
	cin >> n;

	for(int i=0; i <= n; i++){
		cout << setw(3) << i << setw(10) << Fib(i) << endl;
	}

	cout << endl << endl << "Press any key to continue...";

	getch () ;
	return 0;
}

int Fib(int k) {
	if (k == 0 || k == 1) {
		return 1;
	} else {
		return Fib(k-1)+Fib(k-2);
	}
}
