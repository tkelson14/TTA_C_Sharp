using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDrill
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Wade";
            person1.LastName = "Nelson";
            person1.ID = 22;
            person1.SayName();
            Console.ReadLine();

            Person person2 = new Person();
            person2.FirstName = "Peter";
            person2.LastName = "Rasput";
            person2.ID = 11;
            person2.SayName();
            Console.ReadLine();

            if (person1 == person2)
                Console.WriteLine("Wade Nelson and Peter Rasput have the same Employee IDs.");
            else
                Console.WriteLine("Wade Nelson and Peter Rasput do not have the same Employee IDs.");
            Console.ReadLine();
        }
    }
}
