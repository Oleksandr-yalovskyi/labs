#include <iostream>
using namespace std;

inline int Double(int);

int main(){
	int target;

	cout << "Enter a number : ";
	cin >> target;
	cout << " \n";
	target = Double(target);
	cout << " Target " <<  target <<  endl;
	target = Double(target);
	cout << " Target "<<  target <<  endl;
	target = Double(target);
	cout << " Target "<<  target <<  endl;
	return 0;
}

int Double(int target){
	return 2*target;
}
