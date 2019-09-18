using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_5
{
    class Program
    {
        static void Main()
        {
            bool Bval;
            string Sn1;
            int In1, In2, val3;
            //
            do
            {
                Console.WriteLine("Please type a number:");
                Sn1 = Console.ReadLine();
                Bval = false;
                Bval = int.TryParse(Sn1, out In1);
            } while (!Bval);
            //
            In2 = Cdivcs.Cdivs(In1);
            Console.WriteLine("First method, value: " + In2);
            //
            Cdivcs.Cdivs(In1, out val3);
            Console.WriteLine("Second method, value: " + val3);
            //
            Console.ReadLine();
        }
    }
}
