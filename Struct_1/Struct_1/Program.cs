using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_1
{
    class Program
    {
        static void Main()
        {
            Number num = new Number();
            num.Amount = 100.23m;
            Console.WriteLine("Amount is: " + num.Amount);
            Console.ReadLine();
        }
        public struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}
