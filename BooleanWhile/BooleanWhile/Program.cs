using System;

namespace BooleanWhile
{
    class Program
    {
        static void Main()
        {
            string Scolor;
            int Inum = 0;
            bool Bcolor = false;
            //
            Console.WriteLine("Type the color:");
            Scolor = Console.ReadLine();
            Bcolor = Scolor == "Red";
            while (!Bcolor)
            {
                Inum++; 
                Console.WriteLine("Attempt.:" + Inum + "\nType the color:");
                Scolor = Console.ReadLine();
                Bcolor = Scolor == "Red";
            }
            Console.WriteLine("Congratulations!....Red is the color.");
            Console.ReadLine();
            //
            //
            //
            do
            {
                Inum++;
                Console.WriteLine("Attempt.:" + Inum + "\nType the color:");
                Scolor = Console.ReadLine();
                Bcolor = Scolor == "Blue";
            }
            while (!Bcolor);
            Console.WriteLine("Congratulations!....Blue is the color.");
            Console.ReadLine();
        }

    }
}
