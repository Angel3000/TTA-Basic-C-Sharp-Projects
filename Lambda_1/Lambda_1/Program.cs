using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_1
{
    class Program
    {
        static void Main()
        {
            List<Employee> ListEmp = new List<Employee>();
            Employee emp = new Employee();
            //
            emp.Fname = "John";
            emp.Lname = "Smith";
            emp.Id = 1;
            ListEmp.Add(emp);
            emp.Fname = "Joe";
            emp.Lname = "Smith";
            emp.Id = 11;
            ListEmp.Add(emp);
            emp.Fname = "Jane";
            emp.Lname = "Doe";
            emp.Id = 2;
            ListEmp.Add(emp);
            emp.Fname = "Tim";
            emp.Lname = "Curry";
            emp.Id = 13;
            ListEmp.Add(emp);
            emp.Fname = "Maria";
            emp.Lname = "Prieto";
            emp.Id = 44;
            ListEmp.Add(emp);
            emp.Fname = "Susan";
            emp.Lname = "White";
            emp.Id = 155;
            ListEmp.Add(emp);
            emp.Fname = "Joe";
            emp.Lname = "King";
            emp.Id = 166;
            ListEmp.Add(emp);
            emp.Fname = "Joe";
            emp.Lname = "Door";
            emp.Id = 177;
            ListEmp.Add(emp);
            emp.Fname = "Susan";
            emp.Lname = "Gates";
            emp.Id = 3;
            ListEmp.Add(emp);
            emp.Fname = "Ella";
            emp.Lname = "Ramdom";
            emp.Id = 4;
            ListEmp.Add(emp);
            emp.Fname = "Tim";
            emp.Lname = "Smith";
            emp.Id = 200;
            ListEmp.Add(emp);
            //
            List<Employee> temp = new List<Employee>();
            foreach (Employee ee in ListEmp)
            {
                if (ee.Fname == "Joe")
                {
                    temp.Add(ee);
                }
            }
            //
            Console.WriteLine("All Joe's on the list:");
            foreach (Employee tt in temp)
            {
                Console.WriteLine("{0} {1}, Id: {2}", tt.Fname, tt.Lname, tt.Id );
            }
            //
            List<Employee> temp2 = ListEmp.Where(x => x.Fname == "Joe").ToList();
            Console.WriteLine("\nAll Joe's on the list using lambda:");
            foreach (Employee ee in temp2)
            {
                Console.WriteLine("{0} {1}, Id: {2}", ee.Fname, ee.Lname, ee.Id);
            }
            //
            List<Employee> temp3 = ListEmp.Where(x => x.Id > 5).ToList();
            Console.WriteLine("\nAll employees with Id greater than 5:");
            foreach (Employee ee in temp3)
            {
                Console.WriteLine("{0} {1}, Id: {2}", ee.Fname, ee.Lname, ee.Id);
            }

            Console.ReadLine();
        }
    }
}
