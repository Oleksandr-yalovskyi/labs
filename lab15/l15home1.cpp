#include <iostream>
#include <string.h>
#include <math.h>
using namespace std;

struct Note {
	char name[50];
	char surname[50];
	int phone;
	int bdate[3];
	int tel3numb;
};

void personInfo(int num, Note NOTE) {
	cout << "Persone " << num + 1 << ":" << endl;
	cout << "Name: " << NOTE.name << " " << NOTE.surname << endl;
	cout << "Phone number: " << NOTE.phone << endl;
	cout << "Birth date: " << NOTE.bdate[0] << "." << NOTE.bdate[1] << "." << NOTE.bdate[2] << endl;
}

int main() {
	const int k = 50, m = 3;
	int n;
	int cnt = 0;
	Note* NOTE = new Note[n];

	cout << "Enter count of persons: ";
	cin >> n;

	for (int i = 0; i < n; i++) {
		cout << "Persone " << i + 1 << endl;
		cout << "Enter Name: ";
		cin >> NOTE[i].name;
		cout << "Enter Surname: ";
		cin >> NOTE[i].surname;
		cout << "Enter phone number: ";
		cin >> NOTE[i].phone;
		cout << "Enter birthdate" << endl;
		cout << "Day: ";
		cin >> NOTE[i].bdate[0];
		cout << "Month: ";
		cin >> NOTE[i].bdate[1];
		cout << "Year: ";
		cin >> NOTE[i].bdate[2];
		cout << endl;

		int tel = NOTE[i].phone;
		int len = (int)log10((double)tel) + 1;
		char* strtel = new char[len + 1];
		char* tel3 = new char[len + 1];

		for (int i = len - 1; i >= 0; i--) {
			int chartel = tel % 10;
			strtel[i] = '0' + chartel;
			tel /= 10;
		}

		strtel[len] = '\0';
		for (int j = 0; j < 3; j++) {
			tel3[j] = strtel[j];
			cnt++;
			if (cnt == 3) { break; }
		}
		tel3[m] = '\0';
		NOTE[i].tel3numb = atoi(tel3);
	}

	for (int i = m; i > 0; i--) {
		for (int j = 1; j < i; j++) {
			if (NOTE[i].tel3numb > NOTE[i + 1].tel3numb) {
				Note temp = NOTE[i];

				NOTE[i] = NOTE[i + 1];
				NOTE[i + 1] = temp;
			}
		}
	}

	for (int i = 0; i < n; i++) {
		personInfo(i, NOTE[i]);
		cout << endl;
	}

	char search[k];

	while (true) {
		cout << "Enter Surname of persone you are looking for or end to exit: ";
		cin >> search;
		if (strcmp(search, "end") == 0) { break; }
		for (int i = 0; i < n; i++) {
			if (strstr(NOTE[i].surname, search)) {
				if (NOTE[i].surname[strlen(search)] == ' ' || NOTE[i].surname[strlen(search)] == '\0') {
					personInfo(i, NOTE[i]);
				}
			}
		}
	}

	return 0;
}
