using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIODrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number.");
            string num = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Mini\Downloads\log.txt", num);
            Console.WriteLine("Here is your number {0}", num);
            Console.ReadLine();
        }
    }
}
