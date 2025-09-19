#include "Circle.h"
#include <iostream>
using namespace std;

int main() {
    Circle c1;
    cout << "Default Circle:" << endl;
    c1.print();

    c1.setR(5.0);
    cout << "\nCircle with R = 5.0:" << endl;
    c1.print();

    Circle c2(3.0);
    cout << "\nCircle with R = 3.0:" << endl;
    c2.print();

    return 0;
}