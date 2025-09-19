#pragma once

class Receipt {
private:
    int number_ = 0;
    int date_ = 0;
    float summa_ = 0;

public:
    Receipt();
    Receipt(int number, int date, float summa);
	Receipt(const Receipt&);
	~Receipt();

    int getNumber() const;
    int getDate() const;
    float getSumma() const;

    void setNumber(int number);
    void setDate(int date);
    void setSumma(float summa);
	void setAll(int number, int date, float summa);

    void print() const;
};