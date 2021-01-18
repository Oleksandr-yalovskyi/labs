#include <iostream>
using namespace std;

int main() {
	int size = 5;
	int A[size][size], B[size][size];
	float zeroCount = 0, count = 0;
	float ratio = 0;

	for ( int i = 0; i < size; i++ ) {
		for ( int j = 0; j < size; j++ ) {
			A[i][j] = rand() % 5;
			if ( A[i][j] == 0 ) {
				zeroCount++;
				
			} else {
				count++;
			}
		}
	}

    ratio += zeroCount/count;

	cout << "The ratio of the number of zero elements to the number of non-zero: " << ratio << endl;
	
	cout << "Matrix A: " << endl;

    for ( int col = 0; col < size; col++ ) {
		for ( int row = 0; row < size; row++ ) {
			cout << A[row][col] << " ";
		}
		cout << endl;
	}
	
	cout << "Matrix B: " << endl;

    for ( int col = 0; col < size; col++ ) {
		for ( int row = 0; row < size; row++ ) {
			B[row][col] = A[size-1-row][col];
			cout << B[row][col] << " ";
		}
		cout << endl;
	}

	return 0;
}
