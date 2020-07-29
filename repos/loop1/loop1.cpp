// loop1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <math.h>
#include <string>
using namespace std;

int main() {
    int n, p;
    float x{}, sumtoys{}, summoney{}, sumtotal{};
    cin >> n >> x >> p;
    for (int i = 1; i <= n; i++) {
        if (i % 2 == 1) {

            sumtoys += p;
        }
        else {
            summoney += ((5 * i) - 1);
        }
    }
        cout.setf(ios::fixed);
        cout.precision(2);
        sumtotal = sumtoys + summoney;

        if (sumtotal >= x)
            cout << "Yes! " << sumtotal - x << endl;
        else
            cout << "No! " << x - sumtotal  << endl;
       
    return 0;
}

int main10() {
    int n, number, sumeven{}, sumodd{};
    cin >> n;
    for (int i = 0; i < n; i ++)
    {
        cin >> number;
        if (i % 2 == 0)
            sumeven += number;
        else
            sumodd += number;
    }
   
    if (sumeven == sumodd) {
        cout << "Yes" << endl;
        cout << "Sum = " << sumeven << endl;
    }
    else {
        cout << "No" << endl;
        cout << "Diff = " << abs(sumeven - sumodd) << endl;
    }
    return 0;
}

int main9() {
    int n, number, sumleft{}, sumright{};
    cin >> n;
    for (int i = 0; i < n; i++) {
        cin >> number;
        sumleft += number;
    }
    for (int i1 = 0; i1 < n; i1++) {
        cin >> number;
        sumright += number;
    }
    if (sumleft == sumright) {
        cout << "Yes, sum = " << sumleft << endl;
    }
    else {
        cout << "No, diff = " << abs(sumleft - sumright) << endl;
    }
    return 0;
}

int main8() {
    int n, number;
    cin >> n;
    int max = INT_MIN;
    int min = INT_MAX;
    for (int a = 0; a < n; a++) {
      
        cin >> number;
        
        if (number > max) {
            max = number;
        }
        if (number < min) {
            min = number;
        }
    }
    cout << "Max number: " << max << endl;
    cout << "Min number: " << min << endl;
    return 0;
}


int main7()
{
    int n, number, sum = 0;
    cin >> n;
    for (int a = 0; a < n; a++) {
        cin >> number;
        sum += number;
    }
    cout << sum << endl;
    return 0;
}

int main6()
{
    string text;
    getline(cin, text);
    int sum = 0;
    for (int i = 0; i < text.length(); i++) {
         char letter = text[i];
        switch (letter) {
        case 'a':
            sum += 1;
            break;
        case 'e':
            sum += 2;
            break;
        case 'i':
            sum += 3;
            break;
        case 'o':
            sum += 4;
            break;
        case 'u':
            sum += 5;
            break;
        }
    }
    cout << sum << endl;
    return 0;
}

int main5()
{
    string text;
    getline(cin, text);
    for (int i = 0; i < text.length(); i++)
        cout << text[i] << endl;
    return 0;
}

int main4()
{
    int n;
    cin >> n;
    for (int i = pow(2, 0); i <= pow(2, n); i *= 4)
        cout << i << endl;
    return 0;
}

int main3()
{
    int n;
    cin >> n;
    for (int i = 1; i <= n; i += 3)
        cout << i << endl;
    return 0;
}

int main2()
{
    int N;
    cin >> N;
    for (int a = N; a >= 1; a--)
        cout << a << endl;
    return 0;
}

int main1()
{
    for (int a = 1; a <= 100; a++)
        cout << a << endl;
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
