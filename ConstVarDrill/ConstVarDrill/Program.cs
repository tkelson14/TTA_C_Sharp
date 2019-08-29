using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            const string var = "Joe Wilson";
            var dict = new Dictionary<int, int>();

            Constructors con1 = new Constructors(var);
            Console.WriteLine("Name: {0} Id: {1} isTrue: {2}", con1.Name, con1.Id, con1.isTrue);

            Constructors con2 = new Constructors(var, 250, false);
            Console.WriteLine("Name: {0} Id: {1} isTrue: {2}", con2.Name, con2.Id, con2.isTrue);
            Console.ReadLine();
        }
    }
    public class Constructors
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool isTrue { get; set; }

        public Constructors(string name) : this (name, 100, true)
        {

        }
        public Constructors(string name, int id) : this(name, id, true)
        {

        }
        public Constructors(string name, int id, bool istrue)
        {
            Name = name;
            Id = id;
            isTrue = istrue;
        }

    }
}
