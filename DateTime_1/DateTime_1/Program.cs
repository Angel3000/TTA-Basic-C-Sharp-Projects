using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_1
{
    class Program
    {
        static void Main()
        {
            bool quit = false;
            int num;
            Console.WriteLine("Actual Date and Time: " + DateTime.Now);
            //
            do
            {
                try
                {
                    Console.WriteLine("Please enter a number of hours");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The date and time will be:" + DateTime.Now.AddHours(num));
                    quit = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please just type numbers.");
                }
                finally
                {
                    Console.ReadLine();
                }
            } while (!quit);
        }
    }
}
