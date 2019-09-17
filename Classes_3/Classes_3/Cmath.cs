using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3
{
    public class Cmath
    {
        public int Dmath(int val1) 
        {
            int val2 = 0;
            val2 = val1 * 1000;
            return val2;
        }
        public int Dmath(decimal val1)
        {
            int val2 = 0;
            val2 = Convert.ToInt32(val1);
            val2 = val2 * 2;
            return val2;
        }
        public int Dmath(string val1)
        {
            try
            {
                int val2 = 0;
                val2 = Convert.ToInt32(val1);
                val2 = val2 * 4;
                return val2;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please send just numbers.");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
