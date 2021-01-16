#include <iostream>
using namespace std;

int min(double a, double b) {
	if ( a > b ) {
		return b;
	} else {
		return a;
	}
}

int main() {
	float A[10], B[10], C[10];
	float *a = A;
	float *b = B;
	float *c = C;

	for ( int i = 0; i < 10; i++ ) {
		*(a+i) = rand() % 6 - 2.5;
		*(b+i) = rand() % 5 - 2.5;
		cout << *(a+i) << " ";
	}
	for ( int i = 0, j = 9; i < 10, j >= 0; i++, j-- ) {
		*(c+i) = min(*(a+i), *(b+j));
		//cout << *(c+i) << " ";
	}

	float maxA = *(a+0);
	float maxB = *(b+0);
	float maxC = *(c+0);

	for ( int i = 0; i < 10; i++ ) {
        if (maxA > 0) {
            maxA = *(a+i);
        }
        if ( *(a+i) < 0 ) {
			if ( maxA < *(a+i) ) {
				maxA = *(a+i);
			}
		}
		if (maxB > 0) {
            maxB = *(b+i);
        }
        if ( *(b+i) < 0 ) {
            if ( maxB < *(b+i) ) {
                maxB = *(b+i);
		 	}
        }
        if (maxC > 0) {
            maxC = *(c+i);
        }
        if ( *(c+i) < 0 ) {
		 	if ( maxC < *(c+i) ) {
		 		maxC = *(c+i);
		 	}
        }
	}

	cout << endl;

	cout << "Max negative in A: " << maxA << endl;
	cout << "Max negative in B: " << maxB << endl;
	cout << "Max negative in C: " << maxC << endl;

	return 0;
}
