#include <iostream>
using namespace std;

int rgcd (int vl, int v2){
	if (v2 != 0) {
		return rgcd (v2, vl% v2);
	}
	return vl;
}

int main() {
	int x = 153, y = 3;

	cout << rgcd(x, y) << endl;

	return 0;
}
