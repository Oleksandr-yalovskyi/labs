#include <iostream>
using namespace std;

void swap( int vl, int v2 ) {
	int tmp = v2;
	v2 = vl;
	vl = tmp;
}

int main() {
	int i = 10;
	int j = 20;
	cout << "Перед swap():\ti: " << i << "\tj:" << j << endl;
	swap( i, j );
	cout << "Після swap():\ti: " << i << "\tj:" << j << endl;
	return 0;
}
