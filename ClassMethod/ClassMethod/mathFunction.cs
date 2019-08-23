using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class mathFunction
    {
       
        public static void divide(int inNum)
        {
            int total = inNum / 2;
            Console.WriteLine(total);
        }
        public static void divide(int inNum1, out int outNum2)
        {
            int total = outNum2 = inNum1 / 2;
            //Console.WriteLine(total);
        }
        public static class empty
        {

        }
    }
}
