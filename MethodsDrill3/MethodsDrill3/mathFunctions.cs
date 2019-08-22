using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDrill3
{
    class mathFunctions
    {
        public int addition(int num1)
        {
            int results = num1 + 5;
            return results;
        }
        public decimal addition(decimal num1)
        {
            decimal results = num1 * 9;
            return Convert.ToInt32(results);
        }
        public int addition(string num1)
        {
            int results = Convert.ToInt32(num1) + 15;
            return results;
        }
    }
}
