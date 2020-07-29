// pravoyg v ravninata.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <math.h>
using namespace std;

int main()
{
	double whiskeyprice, beerq, wineq, rakiaq, whiskeyq;
	
	cin >> whiskeyprice;
	cin >> beerq;
	cin >> wineq;
	cin >> rakiaq;
	cin >> whiskeyq;

	double money;
	money = whiskeyprice * whiskeyq + whiskeyprice * rakiaq / 2 + 0.3 * whiskeyprice * wineq + 0.1 * whiskeyprice * beerq;
	cout.setf(ios::fixed);
	cout.precision(2);
	cout << money << endl;

	return 0;
}

int main3()
{
	int days, people, cakesaday, goffaday, pancakesaday;
	cin >> days;
	cin >> people;
	cin >> cakesaday;
	cin >> goffaday;
	cin >> pancakesaday;

	double money;
	money = days * people * (cakesaday * 45 + goffaday * 5.80 + pancakesaday * 3.20) * 7 / 8;
	cout.setf(ios::fixed);
	cout.precision(2);
	cout << money << " BGN" << endl;

	return 0;
}

int main2()
{
	double L, W, A, area, dancer = 0.7040, num;
	cin >> L;
	cin >> W;
	cin >> A;

	area = 0.9 * L * W - A * A;
	num = area / dancer;
	cout << floor(num) << endl;

	return 0;
}

 int main1()
{
	int tables;
	double length;
	double width;
	cin >> tables;
	cin >> length;
	cin >> width;
	double cloth;
	double sq;
	cloth = (0.6 + length) * (0.6 + width);
	sq = length * length / 4;
	double usd;
	usd = tables * (cloth * 7 + sq*9);
	double bgn;
	bgn = 1.85 * usd;
	cout.setf(ios::fixed);
	cout.precision(2);
	cout << usd << " USD" <<endl;
	cout << bgn << " BGN" <<endl;

	return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
