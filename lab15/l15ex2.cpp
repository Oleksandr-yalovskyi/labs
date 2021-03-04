#include <iostream>
#include <conio.h>
using namespace std;

const int n = 6;

int main() {

	struct Monitor {
		char name[20];
		int garant;
		float cena;
	} mon[n] = {"Samsung 757 NF ", 36, 1100.1,
				"Sony CPD-C520K", 36, 11753.4,
				"Hansol H95S TFT ", 24, 4260.2,
				"Samsung 757 DFX ", 12, 1054.5,
				"LG T710H Flatron ", 36, 855.,
				"Samsung 192V TFT ", 36, 4252.2 };
	int i, k;

	cout << "\t ******* Spisok monitorov ******* \n";

	for (i = 0; i < n; i++) {
		cout << (*(mon + i)).name;
		cout << (*(mon + i)).garant;
		cout << (*(mon + i)).cena << "\n";
	}

	Monitor rab;

	for (k = 1; k < n; k++) {
		for (i = 0; i < n - k; i++) {
			if ((*(mon + i)).cena < (*(mon + i + 1)).cena) {
				rab = *(mon + i);
				*(mon + i) = *(mon + i + 1);
				*(mon + i + 1) = rab;
			}
		}
	}

	cout << "\n\n\t ******* Sortirovka monitorov ******\n";

	for (i = 0; i < n; i++) {
		cout << " cena: ";
		cout << (*(mon + i)).cena;
		cout << " monitor ";
		cout << (*(mon + i)).name;
		cout << " garantij: ";
		cout << (*(mon + i)).garant << "\n";
	}

	return 0;
}
