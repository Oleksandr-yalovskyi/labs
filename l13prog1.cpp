#include <iostream>
using namespace std;

int min(double a, double b) {
	if ( a > b ) {
		return b;
	} else {
		return a;
	}
}

void arrayPrint(float array[], int size) {
    for ( int i = 0; i < size; i++ ) {
    cout << array[i] << " ";
    }
}

void sort(float array[], int size) {
    for ( int i = size; i > 0; i-- ) {
        for ( int j = 1; j < i; j++ ) {
            if ( array[j-1] > array[j] ) {
                float buf = array[j-1];

                array[j-1] = array[j];
                array[j] = buf;
            }
        }
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
	}

	for ( int i = 0, j = 9; i < 10, j >= 0; i++, j-- ) {
		*(c+i) = min(*(a+i), *(b+j));
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

    cout << "Max negative in A: " << maxA << endl;
	cout << "Max negative in B: " << maxB << endl;
	cout << "Max negative in C: " << maxC << endl;

    sort(A, 10);
    sort(B, 10);
    sort(C, 10);

    cout << "Array A: ";
    arrayPrint(A, 10);
    cout << endl;

    cout << "Array B: ";
    arrayPrint(B, 10);
    cout << endl;

    cout << "Array C: ";
    arrayPrint(C, 10);
    cout << endl;
	
	return 0;
}
