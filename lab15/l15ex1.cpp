#include <iostream>
#include <string.h>
#include <conio.h>
using namespace std;

int main() {
	const int n = 3;
	int i;
	float sm, sf, sp;

	struct stud {
		char fam[25];
		int mat, fiz, prg;
		float sb;
	} ved[n];

	sm = sf = sp = 0;

	for (i = 0; i < n; i++) {
		cout << "***** Enter information about " << (i + 1) << " student\n"; 
		{
			cout << "Enter surname and initials\n";
			cin >> (ved[i].fam);
			cout << "Grades in maths, physics, programming\n";
			cin >> ved[i].mat >> ved[i].fiz >> ved[i].prg;
			ved[i].sb = (float(ved[i].mat + ved[i].fiz + ved[i].prg)) / 3;

			sm += ved[i].mat;
			sf += ved[i].fiz;
			sp += ved[i].prg;
		}
	}

	cout << "\n******* Results of session\n";
	cout.precision(3);
	for (i = 0; i < n; i++) {
		cout << i + 1 << " " << ved[i].fam << " maths = " << ved[i].mat << " physics = " <<
			ved[i].fiz << "programming = " << ved[i].prg << " average = " << ved[i].sb << "\n";
		cout << "\n\nGroup's average in mathematics = " << sm / n;
		cout << "\nGroup's average in physics = " << sf / n;
		cout << "\nGroup's average in programming = " << sp / n;
		cout << "\n\n***** Excelent students in programming: \n";
	}

	for (i = 0; i < n; i++) {
		if (ved[i].prg == 5) cout << ved[i].fam << "\n";
	}

	return 0;
}
