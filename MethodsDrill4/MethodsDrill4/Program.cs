using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDrill4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            int num1 = 0, num2 = 24, result = 0;

            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Enter a number:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("An integer is required.");
                }
            }

            validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Enter a second optional number if you like.");
                    string input = Console.ReadLine();
                    mathFunctions op = new mathFunctions();

                    if (input == "")
                    {
                        result = op.OperationOne(num1);
                    }
                    else
                    {
                        num2 = Convert.ToInt32(input);
                        result = op.OperationOne(num1, num2);
                    }
                    validInput = true;

                    Console.WriteLine("The answer to {0} * {1} is {2}", num1, num2, result);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("An integer is required.");
                }
            }
            Console.ReadLine();
        }
    }
}
