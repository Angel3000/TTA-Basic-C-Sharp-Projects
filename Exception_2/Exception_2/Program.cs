using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_2
{
    class Program
    {
        static void Main()
        {
            bool exit = false;
            do
            {
                try
                {
                    bool anwser = false;
                    int age = 0, birth = 0;
                    while (!anwser)
                    {
                        Console.WriteLine("Please type yor age:");
                        anwser = int.TryParse(Console.ReadLine(), out age);
                        if (!anwser) Console.WriteLine("Please type your age on years.");
                    }
                    if (age < 0) throw new NegativeException();
                    else if (age == 0) throw new ZeroException();
                    else birth = DateTime.Now.Year - age;
                    //
                    Console.WriteLine("You were bone in " + birth);
                    Console.ReadLine();
                    exit = true;
                }
                catch (NegativeException)
                {
                    Console.WriteLine("Please don't use negative numbers");
                    Console.ReadLine();
                }
                catch (ZeroException)
                {
                    Console.WriteLine("Age can not be 0.");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something happened. Please contact I.T.");
                    Console.ReadLine();
                }
            } while (!exit);
        }
        //
        public class ZeroException : Exception
        {
            public ZeroException()
               : base() { }
            public ZeroException(string message)
                : base(message) { }
        }
        //
        public class NegativeException : Exception
        {
            public NegativeException()
               : base() { }
            public NegativeException(string message)
                : base(message) { }
        }
    }
}
