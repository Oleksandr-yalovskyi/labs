#include <iostream>
using namespace std;

float MaxFloat(float x, float y){
	if (x > y) {return x;}
	else {return y;}
}

void main (){
    double x = 10.99;
    double y = 10.999;
    MaxFloat(x, y);
    cout<< MaxFloat(x, y);
}
