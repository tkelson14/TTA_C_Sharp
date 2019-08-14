using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            decimal weight = Convert.ToInt32(Console.ReadLine());
            if (weight <= 50)
            {
                Console.WriteLine("Please enter the package width:");
                decimal width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                decimal height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                decimal length = Convert.ToInt32(Console.ReadLine());
                decimal big = width + height + length;
                if (big <= 50)
                {
                    decimal total = (big * weight / 100);
                    Console.WriteLine("Your estimate total for shipping the package is:" + " $ " + total.ToString("C2"));
                    Console.ReadLine();
                }
                else
                { 
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            
        }
    }
}
