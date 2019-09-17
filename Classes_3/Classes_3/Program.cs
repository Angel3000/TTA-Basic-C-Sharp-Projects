using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3
{
    class Program
    {
        static void Main()
        {
            int n1 = 12;
            decimal n2 = 12.3m;
            string S1= "15";
            Cmath cmath = new Cmath();
            n1 = cmath.Dmath(12);
            Console.WriteLine("The result of first method is: " + n1);
            Console.ReadLine();
            //
            n1 = cmath.Dmath(n2);
            Console.WriteLine("The result of second method is: " + n1);
            Console.ReadLine();
            //
            n1 = cmath.Dmath(S1);
            Console.WriteLine("The result of second method is: " + n1);
            Console.ReadLine();
            //
        }
    }
}
