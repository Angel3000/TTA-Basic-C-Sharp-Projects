using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_7
{
    class Program
    {
        static void Main()
        {
            Employee<string> Sthings = new Employee<string>();
            Sthings.things = new List<string>();
            Sthings.things.Add("Blue");
            Sthings.things.Add("Red");
            Sthings.things.Add("Yellow");
            Sthings.things.Add("Green");
            Sthings.things.Add("Red");
            //
            Console.WriteLine("String List");
            foreach (string tt in Sthings.things)
            {
                Console.WriteLine(tt);
            }
            //
            Employee<int> IThings = new Employee<int>();
            IThings.things = new List<int>();
            IThings.things.Add(12);
            IThings.things.Add(24);
            IThings.things.Add(48);
            IThings.things.Add(96);
            IThings.things.Add(192);
            //
            Console.WriteLine("\nInt List");
            foreach (int tt in IThings.things)
            {
                Console.WriteLine(tt);
            }
            Console.ReadLine();
        }
    }
}
