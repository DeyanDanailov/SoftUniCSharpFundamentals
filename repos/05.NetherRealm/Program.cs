using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05.NetherRealm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine().Split(new char[] {',',' '}, StringSplitOptions.RemoveEmptyEntries);
            SortedDictionary<string, List<double>> daemonHealthAndDamage = new SortedDictionary<string, List<double>>();
            for (int i = 0; i < demons.Length; i++)
            {
                string currentDaemon = demons[i];
                MatchCollection healthSymbols = Regex.Matches(currentDaemon, @"[^\d+\-*\/\.]");
                double currentHealth = 0.0;
                foreach (Match item in healthSymbols)
                {
                    currentHealth += (char.Parse(item.Value));
                }
                MatchCollection damageDigits = Regex.Matches(currentDaemon, @"[-]?\d+\.?\d*");
                double currentDamage = 0.0;
                foreach (Match item in damageDigits)
                {
                    string currentDigit = item.Value;
                    currentDamage += double.Parse(currentDigit);
                    
                }
                MatchCollection damageSymbols = Regex.Matches(currentDaemon, @"[*\/]");
                foreach (Match item in damageSymbols)
                {
                    string currentSign = item.Value;
                    if (currentSign == "*")
                    {
                        currentDamage *= 2;
                    }
                    else if (currentSign == "/")
                    {
                        currentDamage /= 2;
                    }
                }            
                daemonHealthAndDamage[currentDaemon] = new List<double>();
                daemonHealthAndDamage[currentDaemon].Add(currentHealth);
                daemonHealthAndDamage[currentDaemon].Add(currentDamage);
                
            }
            foreach (var item in daemonHealthAndDamage)
            {
                Console.WriteLine($"{item.Key} - {(int)(item.Value[0])} health, {item.Value[1]:f2} damage");
            }
        }
    }
}
