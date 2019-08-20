using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>() { 81, 22, 94, 26, 48, 10, 73, 32, 72, 29, 18 };
                Console.WriteLine("Pick a number to divide our list by.");
                int divideBy = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                foreach (int number in numbers)
                {
                    int answer = number / divideBy;
                    Console.WriteLine(number + " divided by " + divideBy + " equals " + answer);
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("You're out of the loop.");
            Console.ReadLine();
        }
    }
}
