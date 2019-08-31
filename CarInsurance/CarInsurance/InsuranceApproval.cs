using System;
class Program
{
    static void Main()
    {
        //  Variables //
        string Sdui, Sage, Sspeed;
        int Iage, Ispeed;
        bool Bval, Bdui, Bapp;
        //
        Console.SetWindowSize(100, 10);
        Console.Title = "Car Insurance Approval";
        SubQcolor();
        Console.Clear();
        Console.WriteLine("+-------------------------------------+");
        Console.WriteLine("|        Car Insurance Approval       |");
        Console.WriteLine("+-------------------------------------+");
        //
        do
        {
            SubQcolor();
            Console.WriteLine("Please type your age:");
            SubAcolor();
            Sage = Console.ReadLine();
            Bval = false;
            Bval = int.TryParse(Sage, out Iage);
        } while (!Bval);
        //
        do
        {
            SubQcolor();
            Console.WriteLine("Have you ever had a DUI?. Please type false or true.");
            SubAcolor();
            Sdui = Console.ReadLine();
            Bval = false;
            Bval = Boolean.TryParse(Sdui, out Bdui);
        } while (!Bval);
        //
        do
        {
            SubQcolor();
            Console.WriteLine("Please type How many speeding tickets ou have:");
            SubAcolor();
            Sspeed = Console.ReadLine();
            Bval = false;
            Bval = int.TryParse(Sspeed, out Ispeed);
        } while (!Bval);
        //
        Bapp = true;
        if (Iage < 15 || Bdui || Ispeed > 3)
            Bapp = false;
        //
        SubQcolor();
        Console.WriteLine("\n\nAre you qualified?");
        Console.WriteLine(Bapp);
        Console.ReadLine();
        //
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