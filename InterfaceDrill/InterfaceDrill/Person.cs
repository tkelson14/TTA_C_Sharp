using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDrill
{
    public abstract class Person
    {
        public string firstName;
        public string lastName;
        public abstract void SayName();
        public virtual void Quit()
        {
        }
    }
}
