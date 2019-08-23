using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDrill
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("The employee's name is : {0} {1}", firstName, lastName);
        }
    }
}
