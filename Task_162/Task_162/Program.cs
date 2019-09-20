using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_162
{
    class Program
    {
        static void Main()
        {
            const decimal Pi = 3.1416m;
            var temp = new Employee("Jane", "Doe", true, 10);
            var fix = new Employee("Maria", "Lopez");
            //
            Console.WriteLine("Pi number is something like: " + Pi);
            if (temp.Temp)
            {
                Console.WriteLine("\nTemporary employee: {0} {1} for {2} months", temp.Fname, temp.Lname, temp.Time);
            }
            if (!fix.Temp)
            {
                Console.WriteLine("\nNew employee: {0} {1}", fix.Fname, fix.Lname, fix.Time);
            }
            Console.ReadLine();
        }
        //
        public class Employee
        {
            public Employee(string fname, string lname) : this(fname, lname, false, 0) { }
            public Employee(string fname, string lname, bool temp, int months)
            {
                Fname = fname;
                Lname = lname;
                Temp = temp;
                Time = months;
            }
            public string Fname { get; set; }
            public string Lname { get; set; }
            public bool Temp { get; set; }
            public int Time { get; set; }
        }
    }
}
