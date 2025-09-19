#pragma once

class Circle {
private:
    double R;

public:
    Circle();
    Circle(double r);
    double getR();
    void setR(double r);
    double getCircumference();
    double getArea();
    double getSphereVolume();
    void print();
};