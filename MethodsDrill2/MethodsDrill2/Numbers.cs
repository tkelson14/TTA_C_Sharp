using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDrill2
{
    class Void_Method
    {
        public void Pass1(int number1, int number2)
        {
            int total = number1 + 12; //math operation on first integer, user doesn't see it
            Console.WriteLine("Here is the second integer : " + number2); //outputs only 2nd integer to console
            Console.ReadLine();

        }
    }
}
