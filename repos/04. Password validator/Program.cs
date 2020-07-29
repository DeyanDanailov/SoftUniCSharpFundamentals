using System;

namespace _04._Password_validator
{
    class Program
    {
        static bool IfBetween6And10Chars(string password)

        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
               
                return false;
            }
        }
        static bool IfPasswordIsFromLettersAndDigits(string password)

        {
            bool isTrue = false;

            for (int i = 0; i < password.Length; i++)
            {
               
                if (((int)password[i] >= 48 && (int)password[i] <= 57) || ((int)password[i] >= 97 && (int)password[i] <= 122))
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                }
                if (isTrue==false)
                {
                    break;
                }
            }
            if (isTrue)
            {
                return true;
            }
            else
            {
               
                return false;
            }
        }
        static bool IfHaveTwoDigits(string password)

        {
            int digitCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                
                if (((int)password[i] >= 48 && (int)password[i] <= 57) )
                {
                    digitCounter++;
                }               
            }
            if (digitCounter>=2)
            {
                return true;
            }
            else
            {
                
                return false;
            }
        }

        static void Main(string[] args)
        {
            string password = Console.ReadLine().ToLower();

            if (IfBetween6And10Chars(password)==false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (IfPasswordIsFromLettersAndDigits(password)==false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (IfHaveTwoDigits(password)==false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if ((IfBetween6And10Chars(password)) && (IfPasswordIsFromLettersAndDigits(password)) && (IfHaveTwoDigits(password)))
            {
                Console.WriteLine("Password is valid");
            }

        }
    }
}
