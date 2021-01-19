#include <iostream>
using namespace std;

int main() {
	int size = 5;
	int A[size][size], B[size][size];
	float zeroCount = 0, count = 0;

	cout << "Matrix A: " << endl;

	for ( int i = 0; i < size; i++ ) {
	    int *el = A[i];
		for ( int j = 0; j < size; j++ ) {
			*(el+j) = rand() % 5;
			if ( *(el+j) == 0 ) {
				zeroCount++;
			} else {
				count++;
			}
			cout << *(el+j) << " ";
		}
		cout << endl;
	}

	cout << "The ratio of the number of zero elements to the number of non-zero: " << zeroCount/count << endl;
	
	cout << "Matrix B: " << endl;

    for ( int i = 0; i < size; i++ ) {
        int *col = B[i], *el = A[i];
		for ( int j = 0; j < size; j++ ) {
		    *(col+j) = *(el+size-1-j);
		    cout << *(col+j) << " ";
		}
		cout << endl;
	}

	return 0;
}
