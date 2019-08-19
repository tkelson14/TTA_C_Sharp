using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number: ");
            int num = Convert.ToInt16(Console.ReadLine());
            bool isGuessed = false;
            bool fav = false;
            do
            {
                switch (num)
                {
                    case 7:
                        Console.WriteLine("That's Right!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("WRONG, guess again.");
                        Console.WriteLine("Guess the number: ");
                        num = Convert.ToInt16(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            while (!fav)
            {
                Console.WriteLine("That must be your favorite number (true/false): ");
                bool q = Convert.ToBoolean(Console.ReadLine());
                if (q)
                {
                    Console.WriteLine("Well, what do you know! You're awesome! ");
                    fav = true;
                }
                else
                {
                    Console.WriteLine("Well, I guess that is a difference of opinion... ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            Console.ReadKey();
        }
    }
}
