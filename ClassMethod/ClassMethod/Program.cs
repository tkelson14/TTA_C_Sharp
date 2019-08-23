using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            mathFunction userNum = new mathFunction();
            Console.WriteLine("Please enter an interger.");

            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine()); 
                mathFunction.divide(userInput); 
                mathFunction.divide(userInput, out userInput); 
                Console.ReadLine();
            }
            
            catch (FormatException)
            {
                Console.WriteLine("Enter only an integer.");
            }
            
        }
    }
}
