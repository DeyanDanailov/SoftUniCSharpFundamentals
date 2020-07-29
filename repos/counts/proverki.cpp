// proverki.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <math.h>
using namespace std;

int main()
{
	double VacationPrice;
	int RiddleNum = 0, TalkPuppNum = 0, TeddybearNum = 0, MinionNum = 0, TruckNum = 0;
	cin >> VacationPrice;
	cin >> RiddleNum >> TalkPuppNum >> TeddybearNum >> MinionNum >> TruckNum;
	double ToyPrice;
	ToyPrice = RiddleNum * 2.60 + TalkPuppNum * 3 + TeddybearNum * 4.10 + MinionNum * 8.20 + TruckNum * 2;
	double ToyNum = RiddleNum + TalkPuppNum + TeddybearNum + MinionNum + TruckNum;
	if (ToyNum >= 50) //otstupka za 50 i poveche
		ToyPrice = 0.75 * ToyPrice;
	ToyPrice = 0.9 * ToyPrice; //naem
	double LeftMoney;
	LeftMoney = ToyPrice - VacationPrice;
	cout.setf(ios::fixed);
	cout.precision(2);
	if (ToyPrice >= VacationPrice) {

		cout << "Yes! " << abs(LeftMoney) << " lv left." << endl;
	}
	else {
		cout << "Not enough money! " << abs(LeftMoney) << " lv needed" << endl;
	}
	return 0;
}

int main7()
{
	float income;
	float grade;
	float minsalary;
	cin >> income >> grade >> minsalary;
	if (income >= minsalary) {
		if (grade < 5.5)
			cout << "You cannot get a scholarship!" << endl;
		else
			cout << "You get a scholarship for excellent results " << floor(grade *25) << " BGN" << endl;
	}
	else if (grade < 5.5) {
		if (grade > 4.5) {
			cout << "You get a Social scholarship " << floor(0.35 * minsalary) << " BGN" << endl;
		} else 
			cout << "You cannot get a scholarship!" << endl;
	}
	else {
		if (grade * 25 >= 0.35 * minsalary)
			cout << "You get a scholarship for excellent results " << floor(grade * 25) << " BGN" << endl;
		else
			cout << "You get a Social scholarship " << floor(0.35 * minsalary) << " BGN" << endl;
	}
		
	return 0;
}

int main6()
{
	double budget;
	int artists;
	double costumeprice;
	cin >> budget >> artists >> costumeprice;
	double expences;
	if (artists > 150) {
		expences = 0.1 * budget + artists * costumeprice * 0.9;
	}
	else {
		expences = 0.1 * budget + artists * costumeprice;
	}
	cout.setf(ios::fixed);
	cout.precision(2);
	if (expences > budget) {
		cout << "Not enough money!" << endl;
		cout << "Wingard needs " << (expences - budget) << " leva more." << endl;
	}
	else {
		cout << "Action!" << endl;
		cout << "Wingard starts filming with " << (budget - expences) << " leva left." << endl;
	}
	return 0;
}
int main5()
{
	int hour, minutes;
	cin >> hour >> minutes;
	hour <= 23;
	minutes <= 59;
	minutes += 15;
	if (minutes > 59) {
		hour += 1;
		minutes = minutes - 60;
	}
	if (hour > 23) {
		hour = hour - 24;
	}
	if (minutes < 10)
	cout << hour << ":0" << minutes << endl;
	else 
	cout << hour << ":" << minutes << endl;
	return 0;
}

int main4()
{
	float num;
	string measure1, measure2, m, cm, mm;
	cin >> num;
	cin >> measure1 >> measure2;
	cout.setf(ios::fixed);
	cout.precision(3);
	if (measure1 == "mm") {
		num /= 1000;
	}
	else if (measure1 == "cm") {
		num /= 100;
	}
	
	if (measure2 == "mm") {
		num *= 1000;
		cout << num << endl;
	}
	else if (measure2 == "cm") {
		num *= 100;
		cout << num << endl;
	}
	else 
	cout << num << endl;

	return 0;
}

int main3()
{
	double speed;
	cin >> speed;
	if (speed <= 10)
		cout << "slow" << endl;
	else if (speed <= 50)
		cout << "average" << endl;
	else if (speed <= 150)
		cout << "fast" << endl;
	else if (speed <= 1000)
		cout << "ultra fast" << endl;
	else
		cout << "extremely fast" << endl;
	return 0;
}

int main2()
{
	int num;
	cin >> num;
	double bonus = 0;
	if (num <= 100) {
		bonus = 5;
 
	}
	else if (num > 1000) {
		bonus = 0.1 * num;
	}
	else {
		bonus = 0.2 * num;
	}

	if (num % 2 == 0)
		bonus += 1;

	else if (num % 10 == 5)
		bonus = bonus + 2;
	
	cout << bonus << endl;
	cout << num + bonus << endl;

	return 0;
}

int main1()
{
	int timefirst, timesecond, timethird;
	cin >> timefirst >> timesecond >> timethird;
	int sumtime = timefirst + timesecond + timethird;
	int min = sumtime / 60;
	int sec = sumtime % 60;
	if (sec < 10)
		cout << min << ":0" << sec;
	else
		cout << min << ":" << sec << endl;
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
