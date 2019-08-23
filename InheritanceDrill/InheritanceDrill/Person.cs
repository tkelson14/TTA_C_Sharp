using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDrill
{
    class Person
    {
        public string FirstName;// {get; set;} //property
        public string LastName;// {get; set;} //property

        public void SayName() //superclass method
        {
            Console.WriteLine("Name: [{0} {1}]", FirstName, LastName);
        }
    }
}
