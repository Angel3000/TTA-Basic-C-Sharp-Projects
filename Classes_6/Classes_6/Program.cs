using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_6
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            Employee emp2 = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 9999;
            emp2.FirstName = "Check";
            emp2.LastName = "Operator";
            emp2.Id = 9999;
            //
            if (employee.Id == emp2.Id)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            //
            employee.SayName();
            Console.ReadLine();
            employee.Quit(employee.Id);
            Console.ReadLine();
            
        }
        
    }
}
