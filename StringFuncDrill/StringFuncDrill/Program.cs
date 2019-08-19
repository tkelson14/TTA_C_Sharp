using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFuncDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("String demo");
            Console.WriteLine("Tech academy website");
            string prefix = "https://";
            string middle = "learncodinganywhere";
            string suffix = ".com";
            Console.WriteLine(prefix + middle + suffix);
            //end concat

            string anger = "hey now!!!";
            anger = anger.ToUpper();
            Console.WriteLine(anger);
            //end upper
            StringBuilder sb = new StringBuilder();
            sb.Append("On top of the acorn jumps the eventual specialist.\n");
            sb.Append("How does a skull duplicate the reactionary warrant?\n");
            sb.Append("Every dry pacifier succeeds.\n");
            sb.Append("An intuitive bath steeps every lesser politician.\n");
            sb.Append("A quick ham dines before the dusty copper.\n");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
