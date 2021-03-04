#include <iostream>
#include <string.h>
#include <stdio.h>
#include <conio.h>
using namespace std;

int main (){ 
	struct stud{ 
		char fam [20];
		int mat, fiz, prg;
		float sb;
	} st1, st2;

	strcpy (st1.fam, "Кравченко И. С.");

	st1.mat = 4;
	st1.fiz = 5;
	st1.prg = 5;
	st1.sb = float (st1.fiz + st1.mat + st1.prg)/3;
	st2 = st1;
	puts (st2.fam);
	cout << st2.mat << st2.fiz << st2.prg << st2.sb << endl;

	return 0;
}
