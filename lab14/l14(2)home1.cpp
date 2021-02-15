#include <iostream>
using namespace std;

int factorial(int n) {
    if ( n <= 1 ) {
        if ( n < 0 ) {
            return -1;
        }
        return 1;
    }
    return factorial(n-1) * n;
}

int main() {
	int f, rez = 1;
	int n;

	cout << "Enter your number: ";
	cin >> f;

	cout << "Select a calculation method: 0 using for, 1 using recursion" << endl;
	cin >> n;

	switch(n) {
		case 0 : {cout << "you chose for" << endl;
			if ( f < 0 ) {
				cout << "immposible" << endl;
			} else {
				for ( int i = 1; i <= f; i++ ) {
					rez = rez * i;
					cout << i << "! = " << rez << endl;
				}
			}
			break;	
		}
		case 1 :{ cout << "you chose recursion" << endl;
		    for ( int i = 1; i <= f; i ++ ) {
		        rez = factorial(i);
		        cout << i << "! = " << rez << endl;
		    }
		    break;
		}
	}

	return 0;
}
