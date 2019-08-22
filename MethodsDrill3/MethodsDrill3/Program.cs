using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            mathFunctions mathOperations = new mathFunctions();
            int num1 = 12;

            int resultOne = mathOperations.addition(num1);

            decimal resultTwo = mathOperations.addition(15m);

            int resultThree = mathOperations.addition("15");

            Console.WriteLine(resultOne);
            Console.WriteLine(resultTwo);
            Console.WriteLine(resultThree);


            Console.ReadLine();
        }
    }
}
