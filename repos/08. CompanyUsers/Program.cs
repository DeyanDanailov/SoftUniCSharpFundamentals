using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyEmploees = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input!= "End")
            {
                string[] command = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string company = command[0];
                string employeeId = command[1];
                if (!companyEmploees.ContainsKey(company))
                {
                    companyEmploees[company] = new List<string>();
                }
                if (!companyEmploees[company].Contains(employeeId))
                {
                    companyEmploees[company].Add(employeeId);
                }

                input = Console.ReadLine();
            }
            Dictionary<string, List<string>> result = companyEmploees.OrderBy(x => x.Key).ToDictionary(k => k.Key, v => v.Value);
            foreach (var company in result)
            {
                Console.WriteLine(company.Key);
                foreach (var item in company.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
