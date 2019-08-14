using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            string userNumberOne = Console.ReadLine();
            int userNumOne = Convert.ToInt32(userNumberOne);
            int totalOne = userNumOne * 50;
            Console.WriteLine(userNumOne + " * 50 = " + totalOne);
            

            Console.WriteLine("Enter a number.");
            string userNumberTwo = Console.ReadLine();
            int userNumTwo = Convert.ToInt32(userNumberTwo);
            int totalTwo = userNumTwo + 25;
            Console.WriteLine(userNumTwo + " + 25 = " + totalTwo);
            

            Console.WriteLine("Enter a number.");
            string userNumberThree = Console.ReadLine();
            int userNumThree = Convert.ToInt32(userNumberThree);
            double totalThree = userNumThree / 12.5;
            Console.WriteLine(userNumThree + " / 12.5 = " + totalThree);
            

            Console.WriteLine("Enter a number.");
            string userNumberFour = Console.ReadLine();
            int userNumFour = Convert.ToInt32(userNumberFour);
            bool totalFour = userNumFour > 50;
            Console.WriteLine(userNumFour + " > 50 = " + totalFour);
            

            Console.WriteLine("Enter a number.");
            string userNumberFive = Console.ReadLine();
            int userNumFive = Convert.ToInt32(userNumberFive);
            int totalFive = userNumFive % 7;
            Console.WriteLine(userNumFive + " divided by 7 has a remainder of = " + totalFive);
            Console.ReadLine();


            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine("five plus ten = " + total.ToString());
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus 5 = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 10 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotients = 100.0 / 17.0;
            //Console.WriteLine(quotients);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 72;
            //bool isWarm = currentTemp >= roomTemp;
            //bool isWarm = currentTemp == roomTemp;
            //bool isWarm = currentTemp != roomTemp;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();



        }
    }
}
