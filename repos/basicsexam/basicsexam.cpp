// basicsexam.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
using namespace std;
int main() {
    string month, dayornight;
    int hours=0, people=0;
    float priceperperson = 0, totalcost = 0;
    cin >> month >> hours >> people >> dayornight;

    if ((month == "march") || (month == "april") || (month == "may")) {
        if (dayornight == "day") {
            priceperperson = 10.50;
        }
        else if (dayornight == "night") {
            priceperperson = 8.40;
        }
    }
    else if ((month == "june") || (month == "july") || (month == "august")) {
        if (dayornight == "day") {
            priceperperson = 12.60;
        }
        else if (dayornight == "night") {
            priceperperson = 10.20;
        }
    }
    if ((people >= 4) && (hours >=5))  {
        priceperperson =  0.5*0.9*priceperperson;
    }
    if ((people >= 4) && (hours < 5)) {
        priceperperson = 0.9 * priceperperson;
    }
    if ((people < 4) && (hours >= 5)) {
        priceperperson = 0.5 * priceperperson;
    } if ((people < 4) && (hours < 5)) {
        priceperperson = priceperperson;
    }
    totalcost = priceperperson * people * hours;
    cout.setf(ios::fixed);
    cout.precision(2);
    cout << "Price per person for one hour: " << priceperperson << endl;
    cout << "Total cost of the visit: " << totalcost << endl;

    return 0;
}

int main6() {
    int k, i, j, l, counter = 0;
    cin >> k;
    for ( i = 1; i <= 30; i++) {
        for ( j = 1; j <= 30; j++) {
            for ( l = 1; l <= 30; l++) {
                if ((i < j && i < l && j < l) && (i + j + l == k)) {
                    cout << i << " + " << j << " + " << l << " = " << k << endl;
                    counter++;
                }
                if ((i > j&& i > l&& j > l) && (i * j * l == k)) {
                    cout << i << " * " << j << " * " << l << " = " << k << endl;
                    counter++;
                }
            }
        }
    }
    if (counter == 0)
        cout << "No!" << endl;

    return 0;
}

int main5() {
    int kids = 0, adults = 0;
    string input;
    cin >> input;
    while (input != "Christmas") {
        int age = stoi(input);
        if (age <= 16)
            kids++;
        else
            adults++;

        cin >> input;
    }
    cout << "Number of adults: " << adults << endl;
    cout << "Number of kids: " << kids << endl;
    cout << "Money for toys: " << kids * 5 << endl;
    cout << "Money for sweaters: " << adults * 15 << endl;

    return 0;
}

int main4() {
    int n, m, s;
    cin >> n >> m >> s;
    for (int i = m; i >= n;i--) {
        if ((i % 2 == 0) && (i % 3 == 0)) { 
            if (i == s)
                break;
            cout << i << " ";
        } 
    }
   return 0;
}



int main2() {
    float budget, statcount, onestatprice;
    cin >> budget >> statcount >> onestatprice;
    budget = 0.9 * budget;
    cout.setf(ios::fixed);
    cout.precision(2);
    if (statcount > 150)
        onestatprice = 0.9 * onestatprice;
    if (budget < (onestatprice * statcount)) {
        cout << "Not enough money!\n";
        cout << "Wingard needs " << (onestatprice * statcount) - budget << " leva more.\n";
    }
    else {
        cout << "Action!\n";
        cout << "Wingard starts filming with " << budget - (onestatprice * statcount) << " leva left.\n";
    }
   return 0;
}

int main1()
{
    float skumriacena, cacacena, kgpalamud, kgsafrid, kgmidi;
    cin >> skumriacena >> cacacena >> kgpalamud >> kgsafrid >> kgmidi;
    cout.setf(ios::fixed);
    cout.precision(2);
    cout << 1.6 * skumriacena * kgpalamud + 1.8 * cacacena * kgsafrid + 7.5 * kgmidi << endl;
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
