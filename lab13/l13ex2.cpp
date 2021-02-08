#include <iostream>
using namespace std;

int max3(int a,int b, int c){
	int m = a;

	if (b > m) m = b;
	if (c > m) m = c;
	return m;
}

int main() {
	int m;
	int x1,x2,x3;

	cin >> x1 >> x2 >> x3;

	m = max3(x1, x2, x3);

	cout << m << endl;

	return 0;
}
