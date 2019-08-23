using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Person = new Employee() { FirstName = "Sample", LastName = "Student" }; 

            Person.SayName();
            Console.ReadLine();
        }
    }
}
