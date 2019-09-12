using System;
using System.Text;

namespace String_1
{
    class Program
    {
        static void Main()
        {
            string S1 = "The Big", S2 = "House", S3 = "On The Lake", S4;
            StringBuilder SS = new StringBuilder();
            //
            S4 = S1 + " " + S2 + " " + S3;
            Console.WriteLine(S4);
            Console.ReadLine();
            S4 = S4.ToUpper();
            Console.WriteLine(S4);
            Console.ReadLine();
            SS.AppendLine("The House");
            SS.AppendLine("The Lake");
            SS.AppendLine("The Boat");
            Console.WriteLine(SS);
            Console.ReadLine();
        }
    }
}
