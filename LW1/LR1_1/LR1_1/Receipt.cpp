#include "Receipt.h"
#include <iostream>
using namespace std;

Receipt::Receipt() : number_(0), date_(0), summa_(0.0) 
{
	cout << "Vuklukano konstruktor bez parametriv" << this << endl;
}

Receipt::Receipt(int number, int date, float summa) : number_(number), date_(date), summa_(summa)
{
	cout << "Vuklukano konstruktor z parametrom" << this << endl;
}

Receipt::Receipt(const Receipt& other)
	: number_(other.number_), date_(other.date_), summa_(other.summa_)
{
	cout << "Vuklukano konstruktor kopiyuvannya " << this << endl;
}


Receipt::~Receipt()
{
	cout << "Vuklukano destruktor" << this << endl;
}

int Receipt::getNumber() const { return number_; }
int Receipt::getDate() const { return date_; }
float Receipt::getSumma() const { return summa_; }

void Receipt::setNumber(int number) { number_ = number; }
void Receipt::setDate(int date) { date_ = date; }
void Receipt::setSumma(float summa) { summa_ = summa; }
void Receipt::setAll(int number, int date, float summa)
{
	number_ = number;
	date_ = date;
	summa_ = summa;

	cout << "Number: " << number_ << " Date: " << date_ << " Summa: " << summa_ << endl;
}

void Receipt::print() const
{
	cout << "Receipt: " << number_ << " date: " << date_ << " summa: " << summa_ << "\n";
}