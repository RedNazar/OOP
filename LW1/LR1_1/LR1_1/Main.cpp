#include "Receipt.h"
#include <iostream>
#include <conio.h>
using namespace std;

void printReceipt(Receipt ob)
{
    cout << "Druk z funkcii(copy): ";
    ob.print();
}

int main()
{
    Receipt r1;
    r1.setAll(101, 20250907, 250.50);
    r1.print();

    Receipt r2(202, 20250908, 999.99);

    Receipt* pr = new Receipt(303, 20250909, 123.45);
    pr->print();

    Receipt r3 = r2;
    r3.print();

    Receipt arr[2];
    arr[0].setAll(404, 20250910, 111.11);
    arr[1].setAll(505, 20250911, 222.22);
    arr[0].print();
    arr[1].print();

    printReceipt(r1);

    void (Receipt:: * ptrFunc)() const = &Receipt::print;
    (r2.*ptrFunc)();
    (pr->*ptrFunc)();

    delete pr;

    _getch();
    return 0;
}
