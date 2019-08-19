using System;
using System.Collections.Generic;


namespace ArrayListDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 8, 5, 26, 2, 10, 200, 97, 500 };
            string[] strArray = { "blue", "yellow", "green", "car", "truck", "boat", "earth", "water", "fire" };
            List<string> strList = new List<string>();
            strList.Add("Todd");
            strList.Add("Susan");
            strList.Add("Hank");
            strList.Add("Will");
            strList.Add("Joan");
            strList.Add("Jill");
            strList.Add("Sally");
            strList.Add("Bob");
            int userNum = 0;
            int userStr = 0;
            int userList = 0;

            Console.WriteLine("Pick a number between 0 and 7");

            userNum = Convert.ToInt32(Console.ReadLine());
            if (userNum < 7)
            {
                Console.WriteLine("You chose " + (numArray[userNum]));

            }
            else
            {
                Console.WriteLine("It must be between 0 and 7, restart program");
                Console.ReadLine();

            }
            Console.WriteLine("Pick a number between 0 and 7");
            userStr = Convert.ToInt32(Console.ReadLine());
            if (userStr < 7)
            {
                Console.WriteLine("You chose " + (strArray[userStr]));

            }
            else
            {
                Console.WriteLine("It must be between 0 and 7, restart program");
                Console.ReadLine();

            }
            Console.WriteLine("Pick a number between 0 and 7");
            userList = Convert.ToInt32(Console.ReadLine());
            if (userList < 7)
            {
                Console.WriteLine("You chose " + (strList[userList]));

            }
            else
            {
                Console.WriteLine("It must be between 0 and 7, restart program");
                Console.ReadLine();

            }

            
        }
    }
}
