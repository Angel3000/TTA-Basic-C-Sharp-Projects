using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_4
{
    public class Cmath
    {
        public static int cmath(int val1, int val2 = 0)
        {
            int val3;
            val3 = val1 + 50;
            if (!(val2 == 0))
            {
                val3 = val3 - val2;
            }
            return val3;
        }
    }
}