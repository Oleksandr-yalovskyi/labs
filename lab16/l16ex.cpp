#include <conio.h>
#include <iostream>
using namespace std;

class Date{
	public:
		Date(int=1, int=1, int=1990);

		void print();
	private:
		int month;
		int day;
		int year;
};

Date::Date(int m, int d, int y) { 
	month = m;
	day = d;
	year = y;
}

void Date::print(){ 
	cout << month << "-" << day << "-" << year;
}
int main() {
	Date date1(12, 2, 2002), date2;
	cout << "date1 = ";
	date1.print();

	cout << endl << "date2 = ";
	date2.print();
	date2 = date1;
	cout << endl << endl << "date2 = ";
	date2.print();
	getch();
    return 0;
}
