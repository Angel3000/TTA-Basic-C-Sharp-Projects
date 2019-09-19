using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_1
{
    class Program
    {
        static void Main()
        {
            string Sday;
            try
            {
                Console.WriteLine("Please type the current day");
                Sday = Console.ReadLine().ToLower();
                WeekDays wday = (WeekDays)Enum.Parse(typeof(WeekDays), Sday);
                Console.WriteLine("That's a day of the week");
                         }
            catch (System.ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
                
        }
        public enum WeekDays
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        }
    }
}
