// nestedloop2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
using namespace std;

int main() {
    int N;
    cin >> N;
    for (int num1 = 1; num1 <= 9; num1++) {
        for (int num2 = 1; num2 <= 9; num2++) {
            for (int num3 = 1; num3 <= 9; num3++) {
                for (int num4 = 1; num4 <= 9; num4++) {
                    if (N % num1 == 0 && N % num2 == 0 && N % num3 == 0 && N % num4 == 0)
                        cout << num1 << num2 << num3 << num4 << " ";
                }
            }
        }
    }
    return 0;
}

int main5() {
    int n, l;
    cin >> n >> l;
    for (int sym1 = 1; sym1 <= n; sym1++) {
        for (int sym2 = 1; sym2 <= n; sym2++) {
            for (int sym3 = 97; sym3 < 97 + l; sym3++) {
                char a = int(sym3);
                for (int sym4 = 97; sym4 < 97 + l; sym4++) {
                    char b = int(sym4);
                    for (int sym5 = sym1; sym5 <= n; sym5++) {
                        if (sym5 > sym1 && sym5 > sym2) {
                            cout << sym1 << sym2 << a << b << sym5 << " ";
                        }
                    }
                }
            }
        }
    }
    return 0;
}

int main4() {
    int n, students=0;
    float grade=0, gradesum=0, allgrades=0;
    cout.setf(ios::fixed);
    cout.precision(2);
    cin >> n;
    string name;
    cin.ignore();
    getline(cin, name);
    while (name != "Finish") {
        for (int i = 0;i < n;i++) {
            cin >> grade;
            gradesum += grade;
        }
        cout << name << " - " << (gradesum / n) << "." << endl;
        allgrades += (gradesum / n); //sredna ocenka na vseki student
        students++; //broim vseki student
        gradesum = 0;
        cin.ignore();
        getline(cin, name);
    }
    cout << "Student's final assessment is " << (allgrades / students) << "." << endl;
    return 0;
}

int main3() {
    int primesum = 0, nonprimesum = 0,g = 0;
    string number;
    label:
    cin >> number;
    while (number != "stop") {
        int num = stoi(number);
       
        if (num < 0) {
            cout << "Number is negative." << endl;
            goto label;
        }
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                g = 1;
                break;
            }
        }
        if (g == 0)
            primesum += num;
        else
            nonprimesum += num;
        g = 0;
        cin >> number;

}
    cout << "Sum of all prime numbers is: " << primesum << endl;
    cout << "Sum of all non prime numbers is: " << nonprimesum << endl;
    return 0;
}

int main2() {
    int num1,num2;
    cin >> num1 >> num2;
    for ( int j = num1;j <= num2;j++) {
        int number = j;
        string num1str = to_string(number);
        int oddsum = 0, evensum = 0;
        for (int i = 0; i < 6; i++) {
            int digit = num1str[i] - 48;
            if ((i+1) % 2 == 0)
               evensum += digit;
            else if((i+1) % 2 == 1)
               oddsum += digit;          
        }
        if (oddsum == evensum) {

            cout << number << " ";
        } 
    }
    return 0;
}

int main1()
{
    bool flag = false;
    int n,k=1;
    cin >> n;
    for (int row = 1; row <=n;row++) {
        for (int column = 1; column <= row;column++) {
            cout << k++ << " ";
            if (k > n) {
                flag = true;
                break;
            } 
        } cout << endl;
        if (flag)
            break;
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
