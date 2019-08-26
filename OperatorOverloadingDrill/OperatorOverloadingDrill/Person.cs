using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDrill
{
    public class Person : Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ID { get; set; }

        public void SayName()
        {
            Console.WriteLine("Employee Name: {0} {1} Employee ID: {2}" , FirstName, LastName, ID);
        }
        public static bool operator ==(Person person1, Person person2)
        {
            bool status = false;
            if (person1.ID == person2.ID)
            {
                status = true;
            }
            return status;
        }
        public static bool operator !=(Person person1, Person person2)
        {
            bool status = false;
            if (person1.ID != person2.ID)
            {
                status = true;
            }
            return status;
        }

    }
}
