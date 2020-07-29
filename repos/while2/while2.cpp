// while2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>

using namespace std;

int main() {
    int cakesize, width, length, sumpieces=0;
    cin >> width >> length;
    cakesize = width * length;
    string input;
    cin >> input;
    while (input != "STOP") {
        int pieces = stoi(input);
        sumpieces += pieces;
        if (sumpieces > cakesize)
            break;
        else
            cin >> input;
    }
    if (input == "STOP")
        cout << cakesize - sumpieces << " pieces are left." << endl;
    else
        cout << "No more cake left! You need " << sumpieces - cakesize << " pieces more." << endl;
    return 0;
}

int main5() {
    float change=0;
    cin >> change;
    int coins = change * 100;
    //int coins = static_cast<int>(change);
    int sumcoins = 0;
    sumcoins += coins / 200;
    coins = coins % 200;
    sumcoins += coins / 100;
    coins = coins % 100;
    sumcoins += coins / 50;
    coins = coins % 50;
    sumcoins += coins / 20;
    coins = coins % 20;
    sumcoins += coins / 10;
    coins = coins % 10;
    sumcoins += coins / 5;
    coins = coins % 5;
    sumcoins += coins / 2;
    coins = coins % 2;
    sumcoins += coins / 1;
    coins = coins % 1;

    cout << sumcoins << endl;
 
    return 0;
}

int main4() {
    int steps = 0, sumsteps = 0;
    string input;
    getline(cin, input);
    while (input != "Going home") {
        int steps = stoi(input);
        sumsteps += steps;
        if (sumsteps >= 10000)
            break;
        else 
            getline(cin, input);
    }
    if (input == "Going home") {
        cin >> steps;
        sumsteps += steps;
    }
    if (sumsteps >= 10000) {
        cout << "Goal reached! Good job!" << endl;
    }
    else
    {
        cout << 10000 - sumsteps << " more steps to reach goal." << endl;
    }

    return 0;
}

int main3() {
    float vacationprice, money, dailymoney = 0;
    int spenddays = 0,days = 0;
    string action;
    cin >> vacationprice >> money;
    while (money < vacationprice) {
        cin >> action;
        cin >> dailymoney;
        days++;

        if (action == "save") {
            money += dailymoney;
            spenddays = 0;
        }
        else if (action == "spend") {
            money -= dailymoney;
            if (money < 0)
                money = 0;
            spenddays++;
            if (spenddays == 5) {
                cout << "You can't save the money." << endl;
                cout << days << endl;
                exit(0);
            }
             
        }

    }
    cout << "You saved the money for " << days << " days." << endl;

    return 0;
}

int main2() {
    int problems=0, failmax=0, failedlessons=0;
    string lesson="", lastproblem="";
    float sum=0, grade=0;
    cin >> failmax;
    cin.ignore();
    getline(cin,lesson);
    while (lesson != "Enough") {
        
       
            cin >> grade;
            cin.ignore();
            if (grade <= 4) {
                failedlessons++;
                sum += grade;
                problems++;
            }
            else {
                sum += grade;
                problems++;
            }
            if (failmax == failedlessons)
                break;
            lastproblem = lesson;
            getline(cin, lesson);
        
    }
    cout.setf(ios::fixed);
    cout.precision(2);
    if (lesson == "Enough") {
        cout << "Average score: " << sum / problems << endl;
        cout << "Number of problems: " << problems << endl;
        cout << "Last problem: " << lastproblem << endl;
    }
    if (failmax == failedlessons) {
        cout << "You need a break, " << failmax << " poor grades." << endl;
    }
    return 0;
}

int main1()
{
    string mybook, book="";
    int library =0, searched = 0;
    getline(cin,mybook);
    cin >> library;
    
    getline(cin, book);
    
    while (book != mybook) {
        searched ++;
        
        if (searched == library) {
            cout << "The book you search is not here!" << endl;
            cout << "You checked " << searched << " books." << endl;
            exit(0);
        }
        getline(cin, book);
    }

        cout << "You checked " << searched-1 << " books and found it." << endl;
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
