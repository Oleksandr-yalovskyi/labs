#include <iostream>
using namespace std;

void putValues( int[], int size );

int main() {
	int i, j[ 2 ];
	putValues( &i, 1 );
	putValues( j, 2 );
	return 0;
}

const int lineLength =12;

void putValues( int *ia, int sz ){
	cout << "( " << sz << " ) < ";
	for (int i=0; i < sz; ++i ) {
		if ( i % lineLength == 0 && i ) {
			cout << "\n\t";
		}

		cout << ia[ i ];

		if ( i % lineLength != lineLength-1 && i != sz-1 ) {
			cout << ", ";
		}
	}
	cout << " >\n";
}
