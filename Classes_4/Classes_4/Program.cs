using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_4
{
    class Program
    {
        static void Main()
        {
            bool Bval;
            string Sn1;
            int In1, In2, val3;
            do
            {
                Console.WriteLine("Type the first number:");
                Sn1 = Console.ReadLine();
                Bval = false;
                Bval = int.TryParse(Sn1, out In1);
                
            } while (!Bval);
            do
            {
                Sn1 = " ";
                Console.WriteLine("Type the second number. This number is optional:");
                Sn1 = Console.ReadLine(); 
                Bval = false;
                if (string.IsNullOrEmpty(Sn1))
                {
                    Bval = true;
                    In2 = 0;
                }
                else
                {
                    Bval = int.TryParse(Sn1, out In2);
                }
            } while (!Bval);
            Cmath cmath = new Cmath();
            val3 = Cmath.cmath(In1);
            Console.WriteLine("Only with one parameter. Result: " + val3);
            //
            val3 = Cmath.cmath(In1, In2);
            Console.WriteLine("With two parameters. Result: " + val3);
            Console.ReadLine();
        }
    }
}
