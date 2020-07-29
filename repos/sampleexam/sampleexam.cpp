// sampleexam.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <cmath>
using namespace std;

int main() {
    string type, restaurant;
    char order;
    cin >> type;
    cin.ignore();
    getline(cin, restaurant);
    int portions;
    cin >> portions;
    cin >> order;
    float totalprice = 0;

    if (restaurant == "Sushi Zone") {
        if (type == "sashimi") {
            totalprice = 4.99 * portions;
        }
        else if (type == "maki") {
            totalprice = 5.29 * portions;
        }
        else if (type == "uramaki") {
            totalprice = 5.99 * portions;
        }
        else if (type == "temaki") {
            totalprice = 4.29 * portions;
        }
    }
    else if (restaurant == "Sushi Time") {
        if (type == "sashimi") {
            totalprice = 5.49 * portions;
        }
        else if (type == "maki") {
            totalprice = 4.69 * portions;
        }
        else if (type == "uramaki") {
            totalprice = 4.49 * portions;
        }
        else if (type == "temaki") {
            totalprice = 5.19 * portions;
        }
    }
    else if (restaurant == "Sushi Bar") {
        if (type == "sashimi") {
            totalprice = 5.25 * portions;
        }
        else if (type == "maki") {
            totalprice = 5.55 * portions;
        }
        else if (type == "uramaki") {
            totalprice = 6.25 * portions;
        }
        else if (type == "temaki") {
            totalprice = 4.75 * portions;
        }
    }
    else if (restaurant == "Asian Pub") {
        if (type == "sashimi") {
            totalprice = 4.50 * portions;
        }
        else if (type == "maki") {
            totalprice = 4.80 * portions;
        }
        else if (type == "uramaki") {
            totalprice = 5.50 * portions;
        }
        else if (type == "temaki") {
            totalprice = 5.50 * portions;
        }
    }
    else {
        cout << restaurant << " is invalid restaurant!" << endl;
        exit(0);
    }

    int realorder = order;
    if ( realorder == 89)
        totalprice = 1.2 * totalprice;
   
    cout << "Total price: " << ceil(totalprice) << " lv." << endl;
    return 0;
}

int main6() {
    int input;
    cin >> input;
    int firstnum, secondnum, thirdnum;
    firstnum = input % 10;
    secondnum = ((input - firstnum) / 10) % 10;
    thirdnum = (((input - firstnum) / 10) - secondnum) / 10;

    for (int i = 1; i <= firstnum;i++) {
        for (int k = 1; k <= secondnum; k++) {
            for (int j = 1; j <= thirdnum; j++) {
                cout << i << " * " << k << " * " << j << " = " << i * k * j << ";\n";
            }
        }
    }
    return 0;
}

int main5() {
    string input;
    int neededmoney, income = 0, allguests = 0;
    cin >> neededmoney;
    cin.ignore();
    getline(cin, input);
    while (input != "The restaurant is full") {
        int group = stoi(input);
        if (group < 5) {
            income += (group * 100);
        }
        else {
            income += (group * 70);
        }
        allguests += group;

        getline(cin, input);
    }
    if (income >= neededmoney)
        cout << "You have " << allguests << " guests and " << income - neededmoney << " leva left.\n";
    else
        cout << "You have " << allguests << " guests and " << income << " leva income, but no singer.\n";
    return 0;
}

int main4() {
    int startpassengers, stations, offbus = 0, onbus = 0;
    cin >> startpassengers >> stations;
    for (int i = 1; i <= stations; i++) {
        cin >> offbus >> onbus;
        startpassengers -= offbus;
        startpassengers += onbus;
        if (i % 2 == 1)
            startpassengers += 2;
        if (i % 2 == 0)
            startpassengers -= 2;
    }
    cout << "The final number of passengers is : " << startpassengers << endl;

    return 0;
}

int main2() {
    float width, length, height, avgheight;
    float cube = 0, room = 0;
    int astronauts = 0;
    cin >> width >> length >> height >> avgheight;
    cube = width * length * height;
    room = 2 * 2 * (avgheight + 0.4);
    astronauts = cube / room;
    if (astronauts < 3)
        cout << "The spacecraft is too small.\n";
    else if (astronauts >= 3 && astronauts <= 10)
        cout << "The spacecraft holds " << astronauts << " astronauts.\n";
    else
        cout << "The spacecraft is too big.\n";
    return 0;
}

int main1()
{
    float gas = 0, food, totalmoney;
    float souvenirs, hotel;
    gas = 4.2 * 7 * 1.85;
    cin >> food >> souvenirs >> hotel;
    totalmoney = gas + 3 * (food + souvenirs);
    hotel = hotel * (0.8 + 0.85 + 0.9);
    totalmoney = totalmoney + hotel;
    cout.setf(ios::fixed);
    cout.precision(2);
    cout << "Money needed: " << totalmoney << endl;
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
