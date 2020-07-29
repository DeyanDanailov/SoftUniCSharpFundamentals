// nestedloop1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>

using namespace std;
int main() {
    string movie, ticket;
    float freeseats, studenttickets = 0, standardtickets = 0, kidstickets = 0;
    float allfreeseats = 0, allstudents =0, allkids=0, allstandards=0;
    float percent;
    getline(cin, movie);
   
    while (movie != "Finish") {
        cin >> freeseats;
        cin >> ticket;
        while (ticket != "End") {
            
            if (ticket == "student")
                studenttickets++;
            else if (ticket == "standard")
                standardtickets++;
            else if (ticket == "kid")
                kidstickets++;
            if ((studenttickets + standardtickets + kidstickets) == freeseats)
                break;
            cin >> ticket;
        } 
        percent = ((studenttickets + standardtickets + kidstickets) / freeseats) * 100;
        cout.setf(ios::fixed);
        cout.precision(2);
        cout << movie << " - " << percent << "% full." << endl;
       
        allstudents += studenttickets;
        studenttickets = 0;
        allstandards += standardtickets;
        standardtickets = 0;
        allkids += kidstickets;
        kidstickets = 0;
        cin.ignore();
        getline(cin, movie);
    }
    cout.setf(ios::fixed);
    cout.precision(0);
    cout << "Total tickets: " << allstudents + allstandards + allkids << endl;
    cout.setf(ios::fixed);
    cout.precision(2);
    cout << allstudents / (allstudents + allstandards + allkids) * 100 << "% student tickets." << endl;
    cout << allstandards / (allstudents + allstandards + allkids) * 100 << "% standard tickets." << endl;
    cout << allkids / (allstudents + allstandards + allkids) * 100 << "% kids tickets." << endl;

    return 0;
}

int main6() {
    int floors, rooms;
    cin >> floors >> rooms;
    for (int i = floors; i > 0; i--) {
        for (int k = 0; k < rooms; k++) {
            if (i == floors)
                cout << "L" << i << k << " ";
            else if (i  % 2 == 0)
                cout << "O" << i << k << " ";
            else if (i%2 ==1)
                cout << "A" << i << k << " ";
        }
        cout << endl;
    }
    return 0;
}

int main5() {
    string destination;
    float neededmoney, money, sum=0;
    cin >> destination ;
    while (destination != "End") {
        cin >> neededmoney;
        while (sum < neededmoney) {
            cin >> money;
            sum += money;
        }
        cout << "Going to " << destination << "!" << endl;
        sum = 0;
        cin >> destination;
    }
    return 0;
}

int main4() {
    bool flag = false;
    int x1 = 0, x2 = 0, x, y, magic, counter = 0;
    cin >> x >> y >> magic;
    for (x1 = x; x1 <= y; x1++) {
        for (x2 = x; x2 <= y; x2++) {
            counter++;
            if (x1 + x2 == magic) {
                cout << "Combination N:" << counter << " (" << x1 << " + " << x2 << " = " << magic << ")" << endl;
                flag = true;
                break;
            }
        } if (flag == true)
            break;
    }
    if (flag == false)
        cout << counter << " combinations - neither equals " << magic << endl;
    return 0;
}

int main3() {
    int n, counter = 0;
    cin >> n;
    for (int x1 = 0; x1 <= n; x1++) {
        for (int x2 = 0; x2 <= n; x2++) {
            for (int x3 = 0; x3 <= n; x3++) {
                if (x1 + x2 + x3 == n)
                    counter++;
            }
        }
    }
    cout << counter << endl;
    return 0;
}

int main2() {
    for (int i = 1; i <= 10; i++) {
        for (int k = 1; k <= 10; k++)
            cout << i << " * " << k << " = " << i * k << endl;
    }
    return 0;
}

int main1()
{
    for (int i = 0; i <= 23; i++) {
        
        for (int k = 0; k <= 59; k++) {
            cout << i << ":" << k << endl;
        }
   }
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
