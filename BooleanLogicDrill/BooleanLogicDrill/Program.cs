using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageInt = Convert.ToInt32(age);
            bool ageBool = ageInt >= 15;
            Console.WriteLine("Have you ever had a DUI? true or false");
            string dui = Console.ReadLine();
            bool duiBool = Convert.ToBoolean(dui);
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int ticketsInt = Convert.ToInt32(tickets);
            bool ticketsBool = ticketsInt <= 3;

            Console.WriteLine("Qualified?");
            Console.WriteLine(ageBool && ticketsBool && (duiBool == false));            
            Console.ReadLine();
        }
    }
}
