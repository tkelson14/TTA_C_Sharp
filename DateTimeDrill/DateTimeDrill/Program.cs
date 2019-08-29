using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            DateTime myDateTime = DateTime.Now.AddHours(num);            
            Console.WriteLine("It will be {0} in {1} hours.", myDateTime, num);
            Console.ReadLine();
        }
    }
}
