using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Employee<string> employeeStr = new Employee<string>();
            employeeStr.things = new List<string>() { "eric", "mary", "joe" };
            Employee<int> employeInt = new Employee<int>();
            employeInt.things = new List<int>() { 4, 6, 9 };

            foreach (string thing in employeeStr.things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employeInt.things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
