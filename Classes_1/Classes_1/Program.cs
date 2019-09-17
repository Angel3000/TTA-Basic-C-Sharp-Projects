using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_1
{
    class Program
    {
        static void Main()
        {
            int In1, In2;
            string Sn1;
            bool Bval;
            do
            {
                Console.WriteLine("Please type a number:");
                Sn1 = Console.ReadLine();
                Bval = false;
                Bval = int.TryParse(Sn1, out In1);
            } while (!Bval);
            //
            In2 = Cops.DoSum(In1);
            Console.WriteLine("First operation: " + In2);
            In2 = Cops.DoMul(In1);
            Console.WriteLine("Second operation: " + In2);
            In2 = Cops.DoAll(In1);
            Console.WriteLine("Third operation: " + In2);
            Console.ReadLine();
            }
    }
}
