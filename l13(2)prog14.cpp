#include <iostream>
#define SIZE 100
using namespace std;

void matrixPrint(int size, int mat[SIZE][SIZE]) {
    for ( int i = 0; i < size; i++ ) {
        for ( int j = 0; j < size; j++ ) {
            cout << mat[i][j] << " ";
        }
        cout << endl;
    }
}

void matrixFill(int mat[SIZE][SIZE], int size, int range){
	for (int i = 0; i < size; i++) {
		for (int j = 0; j < size; j++) {
			mat[i][j] = rand() % range;
		}
	}
}

int matrixUnique(int size, int mat[SIZE][SIZE]) {
	int max = 0, flag = 0;
	int count = 0;

	for (int i = 0; i < size; i++) {
		for (int j = 0; j < size; j++) {
			if (max < mat[i][j]) {
				max = mat[i][j];
			}
		}
	}

	int a = max;

	int b[a + 1] = { 0 };
	for (int i = 0; i < size; i++) {
		for (int j = 0; j < size; j++) {
			b[mat[i][j]]++;
		}
	}

	for (int i = 1; i <= max; i++) {
		if (b[i] == 1) {
			cout << i << " ";
			flag = 1;
		}
	}

	return count;
}

int diagonalSum(mat[SIZE][SIZE], int size) {
	int sum = 0;

	for( int k = 0; k < size; k++) {
        sum += mat[size - k - 1][k];
	}

	return sum;
}

int main() {
	int size, range;
	int mat[SIZE][SIZE];

	cout << "Enter size: ";
	cin >> size;
	cout << "Enter range: ";
	cin >> range;
	cout << endl;

	matrixPrint(size, mat);
	cout << endl;
	matrixFill(mat, size, range);
	matrixPrint(size, mat);
	cout << matrixUnique(range, mat) << endl;
	cout << diagonalSum(mat, size) << endl;

	return 0;
}
