using System;
class Program
{
    static void Main()
    {
        //  Variables //
        string Sper;
        decimal Dtotal1 = 0, Dtotal2 = 0;
        bool Bcomp;
        //
        Console.SetWindowSize(100, 10);
        Console.Title = "Anonymous Income Comparison Program";
        SubQcolor();
        Console.Clear();
        Console.WriteLine("+---------------------------------------------+");
        Console.WriteLine("|     Anonymous Income Comparison Program     |");
        Console.WriteLine("+---------------------------------------------+");
        //
        Sper = "1";
        SubReq(Sper, out Dtotal1);
        //
        Sper = "2";
        SubReq(Sper, out Dtotal2);
        //
        Bcomp = false;
        if (Dtotal1 > Dtotal2)
             Bcomp = true;
        //
        SubQcolor();
        Console.WriteLine("\n\nWeekly salary of Person 1: " + Dtotal1);
        Console.WriteLine("Weekly salary of Person 2: " + Dtotal2);
        Console.WriteLine("Does Person 1 make more money than Person 2 ?" + Bcomp);
        Console.ReadLine();
        //
    }
    //
    //
    //
    static void SubReq(string Sper, out decimal Dtotal) {
        //
        string Shours, Srate;
        decimal Dhours = 0, Drate = 0;
        bool Bval;
        //
        Console.WriteLine("\n     +------------------------------+");
        Console.WriteLine("     |            Person " + Sper + "          |");
        Console.WriteLine("     +------------------------------+");
        //
        do
        {
            SubQcolor();
            Console.WriteLine("Please type your hourly rate:");
            SubAcolor();
            Srate = Console.ReadLine();
            Bval = false;
            Bval = decimal.TryParse(Srate, out Drate);
        } while (!Bval);
        //
        do
        {
            SubQcolor();
            Console.WriteLine("How many hours do you work per week?");
            SubAcolor();
            Shours = Console.ReadLine();
            Bval = false;
            Bval = decimal.TryParse(Shours, out Dhours);
        } while (!Bval);
        Dtotal = Dhours * Drate;
    }
    //
    //
    static void SubQcolor()
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }

    static void SubAcolor()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }
}