// vlojenif.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <cctype>
using namespace std;

int main()
{
	int days;
	double price = 0;
	string room;
	string grade;
	cin >> days;
	cin >> grade;
	getline(cin, room);
	if (room == "apartment") {
		if (days < 10) {
			if (grade == "positive") {
				price = 25 * (days - 1) * 0.7 * 1.25;
			}
			else {
				price = 25 * (days - 1) * 0.7 * 0.9;
			}
		}
		else if (days >= 10 && days <= 15) {
			if (grade == "positive") {
				price = 25 * (days - 1) * 0.65 * 1.25;
			}
			else {
				price = 25 * (days - 1) * 0.65 * 0.9;
			}
		}
		else {
			if (grade == "positive") {
				price = 25 * (days - 1) * 0.5 * 1.25;
			}
			else {
			price = 25 * (days - 1) * 0.5 * 0.9;
		}
		}
			
	}
	else if (room == "room for one person") {
		if (grade == "positive") {
			price = 18 * (days - 1) * 1.25;
		}
		else {
			price = 18 * (days - 1) * 0.9;
		}
	} else if (room == "president apartment") {
		if (days < 10) {
			if (grade == "positive") {
				price = 35 * (days - 1) * 0.9 * 1.25;
			}
			else {
				price = 35 * (days - 1) * 0.9 * 0.9;
			}
		}
		else if (days >= 10 && days <= 15) {
			if (grade == "positive") {
				price = 35 * (days - 1) * 0.85 * 1.25;
			}
			else {
				price = 35 * (days - 1) * 0.85 * 0.9;
			}
		}
		else {
			if (grade == "positive") {
				price = 35 * (days - 1) * 0.8 * 1.25;
			}
			else {
				price = 35 * (days - 1) * 0.8 * 0.9;
			}
		}

	}
	cout.setf(ios::fixed);
	cout.precision(2);
	cout << price << endl;

	return 0;
}

int main3()
{
	int days;
	string room, grade;
	cin >> days >> room >> grade;
	cout.setf(ios::fixed);
	cout.precision(2);
	if (room == "one") {
		if (grade == "positive")
			cout << 18 * (days - 1) * 1.25 << endl;
		if (grade == "negative")
			cout << 18 * (days - 1) * 0.9 << endl;
	}
	else if (room == "apartment") {
		if (grade == "positive" && days < 10)
			cout << (days - 1) * 25 * 0.7 * 1.25 << endl;
		if (grade == "positive" && (days >= 10 && days <= 15))
			cout << (days - 1) * 25 * 0.65 * 1.25 << endl;
		if (grade == "positive" && days > 15)
			cout << (days - 1) * 25 * 0.5 * 1.25 << endl;
		if (grade == "negative" && days < 10)
			cout << (days - 1) * 25 * 0.7 * 0.9 << endl;
		if (grade == "negative" && (days >= 10 && days <= 15))
			cout << (days - 1) * 25 * 0.65 * 0.9 << endl;
		if (grade == "negative" && days > 15)
			cout << (days - 1) * 25 * 0.5 * 0.9 << endl;
	}
	else if (room == "president")
		
	{
		if (grade == "positive" && days < 10)
		cout << (days - 1) * 35 * 0.9 * 1.25 << endl;
		if (grade == "positive" && (days >= 10 && days <= 15))
		cout << (days - 1) * 35 * 0.85 * 1.25 << endl;
		if (grade == "positive" && days > 15)
		cout << (days - 1) * 35 * 0.8 * 1.25 << endl;
		if (grade == "negative" && days < 10)
		cout << (days - 1) * 35 * 0.9 * 0.9 << endl;
		if (grade == "negative" && (days >= 10 && days <= 15))
		cout << (days - 1) * 35 * 0.85 * 0.9 << endl;
		if (grade == "negative" && days > 15)
		cout << (days - 1) * 35 * 0.8 * 0.9 << endl;
	}
	else
		cout << "error" << endl;

	return 0;
}

int main2()
{
	int age;
	string sex, alcohol;
	cout << "Molya, vyvedete vyzrast i pol" << endl;
	cin >> age >> sex;
	if (age < 18)
		cout << "Mnogo ste malki, za da piete!" << endl;
	else  if (sex == "male") 
	{
			cout << "Zdravejte, Gospodine! Kakyv e lubimiqt vi alkohol?" << endl;
			izbor :
			cin >> alcohol;
			if (alcohol == "rakia") {
				cout << "Predlagame grozdova i kaisieva. Molya izberete." << endl;
				cin >> alcohol;
				if (alcohol == "grozdova")
					cout << "Nazdrave s grozdovata!" << endl;
				else if (alcohol == "kaisieva")
					cout << "Nazdrave, silistreneco!" << endl;
			}
			else if (alcohol == "whiskey") {
				cout << "Predlagame bourbon i scotch. Molya izberete." << endl;
				cin >> alcohol;
				if (alcohol == "bourbon")
					cout << "Nazdrave, Mr Jack!" << endl;
				else if (alcohol == "scotch")
					cout << "Nazdrave, shotlandeco!" << endl;
			}
			else {
				cout << "Molya, izberete mejdu rakia i whiskey!" << endl;
				goto izbor;
			}
	
	}
	else
		cout << "Samo myjete imat pravo da piqt!!!" << endl;

	return 0;
}

int main1()
{
	string Stock;
	string City;
	int quantity;

	cin >> Stock >> City >> quantity;
	if (City == "Sofia" && Stock == "coffee")
		cout << quantity * 0.50 << endl;
	if (City == "Sofia" && Stock == "water")
		cout << quantity * 0.80 << endl;
	if (City == "Sofia" && Stock == "beer")
		cout << quantity * 1.20 << endl;
	if (City == "Sofia" && Stock == "sweets")
		cout << quantity * 1.45 << endl;
	if (City == "Sofia" && Stock == "peanuts")
		cout << quantity * 1.60 << endl;

	if (City == "Plovdiv" && Stock == "coffee")
		cout << quantity * 0.40 << endl;
	if (City == "Plovdiv" && Stock == "water")
		cout << quantity * 0.70 << endl;
	if (City == "Plovdiv" && Stock == "beer")
		cout << quantity * 1.15 << endl;
	if (City == "Plovdiv" && Stock == "sweets")
		cout << quantity * 1.30 << endl;
	if (City == "Plovdiv" && Stock == "peanuts")
		cout << quantity * 1.50 << endl;

	if (City == "Varna" && Stock == "coffee")
		cout << quantity * 0.45 << endl;
	if (City == "Varna" && Stock == "water")
		cout << quantity * 0.70 << endl;
	if (City == "Varna" && Stock == "beer")
		cout << quantity * 1.15 << endl;
	if (City == "Varna" && Stock == "sweets")
		cout << quantity * 1.30 << endl;
	if (City == "Varna" && Stock == "peanuts")
		cout << quantity * 1.50 << endl;
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
