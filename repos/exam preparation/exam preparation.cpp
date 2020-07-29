// exam preparation.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
using namespace std;
int main() {
    float charity;
    int chefs, numberofdishes, sumcookies=0, sumcakes = 0, sumwaffles = 0, allcookies = 0, allcakes = 0, allwaffles = 0, alldishes =0 ;
    string dish, name;
    cin >> chefs;
 
    for (int i = 0; i < chefs;i++) {
        cin >> name;
        //golyam problem s toq ignore :)))
        cin.ignore();
        getline(cin, dish);
        while (dish != "Stop baking!") {
            
            cin >> numberofdishes;
            if (dish == "cookies") {
                sumcookies += numberofdishes;
            }
            else if (dish == "cakes") {
                sumcakes += numberofdishes;
            }
            else if (dish == "waffles") {
                sumwaffles += numberofdishes;
            }
            cin.ignore();
            getline(cin, dish);
        }
        cout << name << " baked " << sumcookies << " cookies, " << sumcakes << " cakes and " << sumwaffles << " waffles.\n";
        allcookies += sumcookies;//zapisvame obshto cookies, predi da zapochne nov gotvach.
        sumcookies = 0;
        allcakes += sumcakes;
        sumcakes = 0;
        allwaffles += sumwaffles;
        sumwaffles = 0;
    }
    alldishes = allcookies + allcakes + allwaffles;
    charity = allcookies * 1.50 + allcakes * 7.80 + allwaffles * 2.30;
    cout.setf(ios::fixed);
    cout.precision(2);
    cout << "All bakery sold: " << alldishes << endl;
    cout << "Total sum for charity: " << charity << " lv." << endl;
    return 0;
}

int main5() {
    int startpoints=0, points=0, counter =0;
    cin >> startpoints;
    string sector;
    cin.ignore();
    getline(cin, sector);
    
    while (sector != "bullseye") {
        cin >> points;
        counter++;
        if (sector == "number section")
            startpoints -= points;
        else if (sector == "double ring")
            startpoints -= points * 2;
        else if (sector == "triple ring")
            startpoints -= points * 3;
        if (startpoints <= 0)
            break;                
        else if (startpoints > 0) {
            cin.ignore();
            getline(cin, sector);
        }
    }
    if (startpoints == 0) 
        cout << "Congratulations! You won the game in " << counter << " moves!\n";
    else if (startpoints < 0)
        cout << "Sorry, you lost. Score difference: " << abs(startpoints) << ".\n";
    else
        cout << "Congratulations! You won the game with a bullseye in " << counter+1 << " moves!\n";
    return 0;
}

int main4() {
    string name, game;
    int games, volgames = 0, tengames = 0, badgames = 0;
    float points = 0, volpoints = 0, tenpoints = 0, badpoints = 0;
    getline(cin, name);
    cin >> games;
    for (int i = 0; i < games; i++) {
        cin >> game >> points;
        if (game == "volleyball") {
            points = 1.07 * points;
            volpoints += points;
            volgames++;
        }
        else if (game == "tennis") {
            points = 1.05 * points;
            tenpoints += points;
            tengames++;
        }
        else if (game == "badminton") {
            points = 1.02 * points;
            badpoints += points;
            badgames++;
        }
    }
        points = floor(volpoints + tenpoints + badpoints);
        if ((floor(volpoints / volgames) > 75) && (floor(tenpoints / tengames) > 75) && (floor(badpoints / badgames) > 75)) {
            cout << "Congratulations, " << name << "! You won the cruise games with " << points << " points.\n";
        }
        else
            cout << "Sorry, " << name << ", you lost. Your points are only " << points << ".\n";
   return 0;
}
int main3() {
    float price = 0;
    string cruise, room;
    int nights;
    getline(cin, cruise);
    getline(cin, room);
    cin >> nights;
    cout.setf(ios::fixed);
    cout.precision(2);
    if (cruise == "Mediterranean") {
        if (room == "standard cabin") {
            price = 4 * (27.50 * nights);
        }
        else if (room == "cabin with balcony") {
            price = 4 * (30.20 * nights);
        }
        else if (room == "apartment") {
            price = 4 * (40.50 * nights);
        }
    }
        else if (cruise == "Adriatic") {
            if (room == "standard cabin") {
                price = 4 * (22.99 * nights);
            }
            else if (room == "cabin with balcony") {
                price = 4 * (25.00 * nights);
            }
            else if (room == "apartment") {
                price = 4 * (34.99 * nights);
            }
    }
        else if (cruise == "Aegean") {
        if (room == "standard cabin") {
            price = 4 * (23.00 * nights);
        }
        else if (room == "cabin with balcony") {
            price = 4 * (26.60 * nights);
        }
        else if (room == "apartment") {
            price = 4 * (39.80 * nights);
        }
    }
    if (nights > 7)
        price = 0.75 * price;
    cout << "Annie's holiday in the " << cruise << " sea costs " << price << " lv.\n";
    return 0;
}

int main2() {
    float budget, towel, discountpercent, sum;
    cin >> budget >> towel >> discountpercent;
    float umbrella, flipflop, bag;
    umbrella = 2 * towel/3;
    flipflop = 0.75 * umbrella;
    bag = (flipflop + towel) / 3;
    sum = (towel + umbrella + bag + flipflop);
    sum = (100 - discountpercent)/100 * sum;
    cout.setf(ios::fixed);
    cout.precision(2);
    if (budget >= sum)
        cout << "Annie's sum is " << sum << " lv. She has " << budget - sum << " lv. left." << endl;
    else 
        cout << "Annie's sum is " << sum << " lv. She needs " << sum - budget << " lv. more." << endl;
    return 0;
}

int main1()
{
    float income, months, expences;
    cin >> income >> months >> expences;
    cout.setf(ios::fixed);
    cout.precision(2);
    cout << "She can save " << 70 - (expences/income)*100 << "%" << endl;//procenta, koito spestqva
    cout << months * (income * 0.7 - expences) << endl;
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
