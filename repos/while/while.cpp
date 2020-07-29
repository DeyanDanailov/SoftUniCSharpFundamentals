// while.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
using namespace std;

int main() {
    int freespace, width, length, height;
    cin >> width >> length >> height;
    freespace = width * length * height;
    int sumbaggage = 0;
    string baggage;
    cin >> baggage;
    while (baggage != "Done") {
        int baggs = stoi(baggage);
        sumbaggage += baggs;
        if (sumbaggage > freespace)
            break;
        cin >> baggage;
    }
    if (sumbaggage > freespace)
        cout << "No more free space! You need " << sumbaggage - freespace << " Cubic meters more." << endl;
    else
        cout << freespace - sumbaggage << " Cubic meters left." << endl;
    return 0;
}

int main89() {
    string name;
    float sum = 0, grade = 0;

    cin >> name;
    int i = 1;
    cout.setf(ios::fixed);
    cout.precision(2);
    while (i <= 12) {
        cin >> grade;
        if (grade < 4.00) {
            cin >> grade;
            if (grade < 4.00) {
                cout << name << " has been excluded at " << i << " grade" << endl;
                exit(0);
            }
        }
        
        sum += grade;
        i++;
    }
    cout << name << " graduated. Average grade: " << sum / 12 << endl;
    return 0;
}

int main67() {
    int n=0, i=0;
    float number, min = INT_MAX;
    cin >> n;

    while (i < n) {
        cin >> number;
        if (number < min)
            min = number;
        i++;
    }
    cout << min << endl;
    return 0;
}

int main5() {
    int n,k=0;
    cin >> n;
    float money, sum = 0;
    cout.setf(ios::fixed);
    cout.precision(2);
    while (k < n) {
        cin >> money;
        if (money < 0) {
            cout << "Invalid operation!" << endl;
            break;
        }
        sum += money;
        cout << "Increase: " << money << endl;
        k++;
    }
    cout << "Total: " << sum << endl;
    return 0;
}

int main4() {
    int n;
    cin >> n;
    int k = 1;
    while (k <= n) {
        cout << k << endl;
        k = 2 * k + 1;
    }
    
    return 0;
}

int main3() {
    int sum = 0;
    string name;
    cin >> name;
    while (name != "Stop")
    {
        
        int num = atoi(name.c_str());
        sum += num;
        cin >> name;
    }
    cout << sum << endl;
    return 0;
}

int main2() {
    string username, password, input;
    cin >> username >> password;
    while (input != password) {
        cin >> input;
    }
    cout << "Welcome " << username << "!" << endl;
    return 0;
}

int main1()
{
    string name;
    while (name != "Stop") {
        cin >> name;
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
