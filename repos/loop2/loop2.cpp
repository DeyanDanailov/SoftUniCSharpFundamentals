// loop2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <cmath>
using namespace std;

int main() {
    int n = 0, salary = 0, fee = 0;
    cin >> n;
    cin >> salary;
    string site;
    for (int i = 0; i < n; i++) {
        cin >> site;
        if (site == "Facebook")
            fee += 150;
        if (site == "Instagram")
            fee += 100;
        if (site == "Reddit")
            fee += 50;
        if (salary <= fee) {
            cout << "You have lost your salary." << endl;
            exit(0);
        }
    }
        cout << salary - fee << endl;
    return 0;
}

int main5() {
    int n = 0, num;
    float p1 = 0, p2 = 0, p3 = 0;
    cin >> n;
    for (int i = 0; i < n; i++) {
        cin >> num;
        if (num %2 == 0)
            p1 += 1;
        if (num% 3==0)
            p2 += 1;
        if (num % 4 ==0)
            p3 += 1;
    }
    cout.setf(ios::fixed);
    cout.precision(2);
    cout << p1 / n * 100 << "%" << endl;
    cout << p2 / n * 100 << "%" << endl;
    cout << p3 / n * 100 << "%" << endl;
    
    return 0;
}

int main4() {
    int n=0, num;
    float p1=0, p2=0, p3=0, p4=0, p5=0;
    cin >> n;
    for (int i = 0; i < n; i++) {
        cin >> num;
        if (num < 200)
            p1 += 1;
        else if ((num >= 200) && (num < 400))
            p2 += 1;
        else if ((num >= 400) && (num < 600))
            p3 += 1;
        else if ((num >= 600) && (num < 800))
            p4 += 1;
        else
            p5 += 1;
    }
    cout.setf(ios::fixed);
    cout.precision(2);
    cout << p1 / n * 100 << "%" << endl;
    cout << p2 / n * 100 << "%" << endl;
    cout << p3 / n * 100 << "%" << endl;
    cout << p4 / n * 100 << "%" << endl;
    cout << p5 / n * 100 << "%" << endl;
    return 0;
}

    int main3() {
    int n;
    float num = 0, oddsum = 0, oddmin = INT_MAX, oddmax = INT_MIN, evensum = 0, evenmin = INT_MAX, evenmax = INT_MIN ;
    cin >> n;
    for (int i = 1; i <= n; i++) {
        cin >> num;
        if ((i % 2) == 1) {
            oddsum += num;
            if (num < oddmin)
                oddmin = num;
            if (num > oddmax)
                oddmax = num;
        }
        else {
            evensum += num;
            if (num < evenmin)
                evenmin = num;
            if (num > evenmax)
                evenmax = num;
        }
    }
    cout.setf(ios::fixed);
    cout.precision(2);
    if (n == 0) {
        cout << "OddSum=" << oddsum << ","<< endl;
        cout << "OddMin=No" << "," << endl;
        cout << "OddMax=No" << "," << endl;
        cout << "EvenSum=" << evensum << "," << endl;
        cout << "EvenMin=No" << "," << endl;
        cout << "EvenMax=No" << endl;
    }
    else if (n == 1) {
        cout << "OddSum=" << oddsum << "," << endl;
        cout << "OddMin=" << oddmin << "," << endl;
        cout << "OddMax=" << oddmax << "," << endl;
        cout << "EvenSum=" << evensum << "," << endl;
        cout << "EvenMin=No" << "," << endl;
        cout << "EvenMax=No" << endl;
    }
    else {
        cout << "OddSum=" << oddsum << "," << endl;
        cout << "OddMin=" << oddmin << "," << endl;
        cout << "OddMax=" << oddmax << "," << endl;
        cout << "EvenSum=" << evensum << "," << endl;
        cout << "EvenMin=" << evenmin << "," << endl;
        cout << "EvenMax=" << evenmax << endl;
    }

    return 0;
}

    int main2() {
    int n;
    int number, sum = 0, max= INT_MIN;
    cin >> n;
    for (int i = 0; i < n; i++) {
        
        cin >> number;
        sum += number;
        if (number > max)
            max = number;
    }
    if (max == (sum -max)) {
        cout << "Yes" << endl;
        cout << "Sum = " << max << endl;
    }
    else {
        cout << "No" << endl;
        cout << "Diff = " << abs(max - (sum - max)) << endl;
    }
    return 0;
}

int main1()
{
    for (int i = 7; i <= 1000; i += 10)
        cout << i << endl;
    
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
