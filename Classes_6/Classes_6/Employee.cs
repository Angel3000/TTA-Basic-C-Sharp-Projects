using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_6
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        //
        public void Quit(int id)
        {
            Console.WriteLine("Employee {0} is leaving", id);
        }
        public static bool operator ==(Employee Id1, Employee Id2)
        {
            if (Id1 == Id2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee Id1, Employee Id2)
        {
            if (Id1 == Id2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}