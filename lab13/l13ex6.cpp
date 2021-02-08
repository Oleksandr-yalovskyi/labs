#include <iostream>
using namespace std;

unsigned long int MyFact(int n){
    int i;
    unsigned long int f = 1;

    for (i=1; i<=n; i++)
        {f = f*i;}
    return f;
}

void main (){
    int k;
    unsigned long int fact;
    k = 6;
    fact = MyFact(k);
    cout << fact; 
}
