using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter current day of the week: ");
                string day = Convert.ToString(Console.ReadLine());
                Day.Days eDay = (Day.Days)Enum.Parse(typeof(Day.Days), day);

                Console.WriteLine(eDay + " is a day of the week");
                Console.ReadLine();

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
    }
}
