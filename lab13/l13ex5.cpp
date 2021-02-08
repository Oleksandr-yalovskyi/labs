#include <iostream>
using namespace std;

float MyAbs(float x){
if (x < 0) {return (float)(-x);}
else {return x;}
}

void main (){
    float res, a;
    
    a = -18.25;
    res = MyAbs(a);
    res = MyAbs(-23);
    cout << res; 
}
