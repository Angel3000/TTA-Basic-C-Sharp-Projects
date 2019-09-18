using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_5
{
    public static class Cdivcs
    {
        public static int Cdivs(int val1)
        {
            int val2 = val1 / 2;
            return val2;
        }
        //
        public static void Cdivs(int val1, out int val2)
        {
            val2 = val1 / 2;
        }
    }
}
