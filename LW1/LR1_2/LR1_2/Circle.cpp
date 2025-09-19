#include "Circle.h"
#include <iostream>
using namespace std;

Circle::Circle() {
    R = 0.0;
}

Circle::Circle(double r) {
    setR(r);
}

double Circle::getR() {
    return R;
}

void Circle::setR(double r) {
    if (r > 0) R = r;
    else R = 1.0;
}

double Circle::getCircumference() {
    return 2 * 3.14 * R;
}

double Circle::getArea() {
    return 3.14 * R * R;
}

double Circle::getSphereVolume() {
    return (4.0 / 3.0) * 3.14 * R * R * R;
}

void Circle::print() {
    cout << "R: " << R << endl;
    cout << "Circumference: " << getCircumference() << endl;
    cout << "Area: " << getArea() << endl;
    cout << "Sphere Volume: " << getSphereVolume() << endl;
}