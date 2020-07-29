// slojni_proverki.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <cmath>
using namespace std;

int main()
{
	int examhour, examminute, studenthour, studentminute, resultminutes, resulthour;
	cin >> examhour >> examminute >> studenthour >> studentminute;
	if (studenthour > examhour) {
		
		if (studentminute >= examminute) {
			if ((studentminute - examminute) < 10) {
				cout << "Late" << endl;
				cout << studenthour - examhour << ":0" << studentminute - examminute << " hours after the start" << endl;
			}
			else if ((studentminute - examminute) >= 10) {
				cout << "Late" << endl;
				cout << studenthour - examhour << ":" << studentminute - examminute << " hours after the start" << endl;
				}
		}
		else if (studentminute < examminute) {
			resultminutes = studentminute + 60 - examminute;
			resulthour = (studenthour - examhour) - 1;
			if ((resulthour >=1) && (resultminutes < 10))
				cout << (studenthour - examhour) - 1 << ":0" << resultminutes << " hours after the start" << endl;
			else if ((resulthour >= 1) && (resultminutes >= 10))
				cout << studenthour - examhour << ":" << resultminutes << " hours after the start" << endl;
			else if ((resulthour < 1) && (resultminutes < 10))
				cout << "0" << resultminutes << " minutes after the start" << endl;
			else if ((resulthour < 1) && (resultminutes >= 10))
				cout << resultminutes << " minutes after the start" << endl;
		}
	} else if (studenthour = examhour) {
		if (studentminute > examminute) {
				cout << "Late" << endl;
			resultminutes = studentminute - examminute;
			if (resultminutes < 10)
				cout << "0" << resultminutes << " minutes after the start" << endl;
			else if (resultminutes >=10)
				cout << resultminutes << " minutes after the start" << endl;
		}
		else if (studentminute <= examminute) {
			resultminutes = examminute - studentminute;
			if ((resultminutes <= 30) && (resultminutes < 10)) {
				cout << "On time" << endl;
				cout << "0" << resultminutes << " minutes before the start" << endl;
			}
			else if ((resultminutes <= 30) && (resultminutes >= 10)) {
				cout << "On time" << endl;
				cout << resultminutes << " minutes before the start" << endl;
			} else if (resultminutes > 30) {
				cout << "Early" << endl;
				cout << resultminutes << " minutes before the start" << endl;
			}
		}
	}
	else if (studenthour < examhour) {
		resulthour = examhour - studenthour;
		if (resulthour == 1) {
			if (studentminute <= examminute) {
				resultminutes = examminute - studentminute;
				cout << "Early" << endl;
				if (resultminutes >= 10)
					cout << resulthour << ":" << resultminutes << " hours before the start" << endl;
				else if ( resultminutes < 10)
					cout << resulthour << ":0" << resultminutes  << " hours before the start" << endl;
			} else if (studentminute > examminute) {
				resultminutes = examminute + 60 - studentminute;
				if (resultminutes > 30) {
					cout << "Early" << endl;
					cout << resultminutes << " minutes before the start" << endl;
				} else if ((resultminutes <= 30) && (resultminutes > 10)) {
					cout << "On time" << endl;
					cout << resultminutes << " minutes before the start" << endl;
				} else if (resultminutes < 10) {
					cout << "On time" << endl;
					cout << "0" << resultminutes << " minutes before the start" << endl;
				}

			}
		}
		else if (resulthour > 1) {
			if (studentminute <= examminute) {
				resultminutes = examminute - studentminute;
				cout << "Early" << endl;
				if (resultminutes >= 10)
					cout << resulthour << ":" << resultminutes << " hours before the start" << endl;
				else if (resultminutes < 10)
					cout << resulthour << ":0" << resultminutes << " hours before the start" << endl;
			}
			else if (studentminute > examminute) {
				resulthour = examhour - studenthour - 1;
				resultminutes = 60 + examminute - studentminute;
				cout << "Early" << endl;
				if (resultminutes < 10)
					cout << resulthour << ":0" << resultminutes << " hours before the start" << endl;
				else if (resultminutes >= 10)
					cout << resulthour << ":" << resultminutes << " hours before the start" << endl;
			}
		}
	}
	return 0;
}

int main10()
{
	string year;
	float p, h, games;
	cin >> year >> p >> h;
	if (year == "normal") {
		games = (2.0 / 3 * p) + (0.75 * (48 - h)) + h;

	} else if(year == "leap") {
		games = 1.15 * ((2.0 / 3 * p) + (0.75 * (48 - h)) + h);
	}
	cout << floor(games) << endl;

	return 0;
}

int main3()
{
	int degrees;
	string time, Outfit, Shoes;
	cin >> degrees >> time;

	if ((degrees >= 10 && degrees <= 18) && (time == "Morning")) {
		Outfit = "Sweatshirt";
		Shoes = "Sneakers"; 
	} else if ((degrees >= 10 && degrees <= 18) && (time == "Afternoon" || time == "Evening")) {
		Outfit = "Shirt";
		Shoes = "Moccasins";
	} else if ((degrees > 18 && degrees <= 24) && (time == "Afternoon")) {
		Outfit = "T-Shirt";
		Shoes = "Sandals";
	} else if ((degrees > 18 && degrees <= 24) && (time == "Morning" || "Evening")) {
		Outfit = "Sweatshirt";
		Shoes = "Sneakers";
	} else if ((degrees >= 25) && (time == "Morning")) {
		Outfit = "T-Shirt";
		Shoes = "Sandals";
	} else if ((degrees >= 25) && (time == "Afternoon")) {
		Outfit = "Swim Suit";
		Shoes = "Barefoot";
	} else if ((degrees >= 25) && (time == "Evening")) {
		Outfit = "Shirt";
		Shoes = "Moccasins";
	}
	cout << "It's " << degrees << " degrees, get your " << Outfit << " and " << Shoes << "." << endl;

	return 0;
}

int main2()
{
	int r, c, people;
	float price;
	string project;
	cin >> project >> r >> c;
	people = r * c;
	if (project == "Premiere")
		price = people * 12.00;
	else if (project == "Normal")
		price = people * 7.50;
	else if (project == "Discount")
		price = people * 5.00;
	cout.setf(ios::fixed);
	cout.precision(2);
	cout << price << " leva" << endl;

	return 0;
}

int main1()
{
	float x1, x2, y1, y2, x, y;
	cin >> x1 >> y1 >> x2 >> y2 >> x >> y;
	if (((x == x1 || x == x2)) && (y >= y1 && y <= y2)) 
	cout << "Border" << endl;
	
	else if  (((y == y1) || (y == y2)) && (x >= x1 && x <= x2)) 
		cout << "Border" << endl;
	
	else 
		cout << "Inside / Outside" << endl;
	
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
