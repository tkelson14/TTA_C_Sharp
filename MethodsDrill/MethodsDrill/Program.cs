using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Math userNum = new Math();
            Console.WriteLine("Chose an integer.");      
            userNum.Value = Convert.ToInt32(Console.ReadLine());
            Math.addTwoInts(userNum.Value); 
            Math.subTwoInts(userNum.Value);
            Math.multTwoInts(userNum.Value);
            Console.ReadLine();

        }
    }
}
