using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string ratePersonOne = Console.ReadLine();
            int ratePersonOneInt = Convert.ToInt32(ratePersonOne);
            Console.WriteLine("Hours worked per week?");
            string hoursPersonOne = Console.ReadLine();
            int hoursPersonOneInt = Convert.ToInt32(hoursPersonOne);
            int weeklySalaryOne = ratePersonOneInt * hoursPersonOneInt;
            

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string ratePersonTwo = Console.ReadLine();
            int ratePersonTwoInt = Convert.ToInt32(ratePersonTwo);
            Console.WriteLine("Hours worked per week?");
            string hoursPersonTwo = Console.ReadLine();
            int hoursPersonTwoInt = Convert.ToInt32(hoursPersonOne);
            int weeklySalaryTwo = ratePersonTwoInt * hoursPersonTwoInt;

            Console.WriteLine("Weekly Salary of Person 1:");
            Console.WriteLine(weeklySalaryOne);
            Console.WriteLine("Weekly Salary of Person 2:");
            Console.WriteLine(weeklySalaryTwo);

            bool oneMoreThanTwo = weeklySalaryOne > weeklySalaryTwo;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(oneMoreThanTwo);
            Console.ReadLine();
        }
    }
}
