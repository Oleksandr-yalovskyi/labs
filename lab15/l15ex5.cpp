#include <iostream>
#include <conio.h>
#include <stdlib.h>
#pragma hdrstop
using namespace std;

struct mailingListRecord {
	char firstName[20];
	char lastName[20];
	char address[50];
	char city[20];
	char state[5];
	int zip;
};

void displayRecord(int num, mailingListRecord mlRec) {
	cout << "Record " << num + 1 << ":" << endl;
	cout << "Name: " << mlRec.firstName << " ";
	cout << mlRec.lastName;
	cout << endl;
	cout << "Address: " << mlRec.address;
	cout << endl << " ";
	cout << mlRec.city << ", ";
	cout << mlRec.state << " ";
	cout << mlRec.zip;
	cout << endl << endl;
}

int main() {
	mailingListRecord listArray[3];
	cout << endl;

	int index = 0;

	for ( ; index < 3; index++ ) {
		cout << "First Name: ";
		cin.getline(listArray[index].firstName, sizeof(listArray[index].firstName) - 1);
		cout << "Last Name: ";
		cin.getline(listArray[index].lastName, sizeof(listArray[index].lastName) - 1);
		cout << "Address: ";
		cin.getline(listArray[index].address, sizeof(listArray[index].address) - 1);
		cout << "City: ";
		cin.getline(listArray[index].city, sizeof(listArray[index].city) - 1);
		cout << "State: ";
		cin.getline(listArray[index].state, sizeof(listArray[index].state) - 1);
		char buff[10];
		cout << "Zip: ";
		cin.getline(buff, sizeof(buff) - 1);
		listArray[index].zip = atoi(buff);
		cout << endl;
	}

	system("CLS");

	for (int i = 0; i < 3; i++) {
		displayRecord(i, listArray[i]);
	}

	cout << "Choose a record: ";
	char rec;
	cin >> rec;

	for (; rec < 0 || rec > 2; ) {
		rec = _getch();
		rec -= 49;
	}

	mailingListRecord temp = listArray[rec];
	system("CLS");
	cout << endl;

	displayRecord(rec, temp);

	return 0;
}
