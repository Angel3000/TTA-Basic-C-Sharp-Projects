using System;
class Program
{
    static void Main()
    {
        //  Variables //
        string Ssize, Sweight;
        decimal Iwidth = 0, Iweight = 0, Iheight = 0, Ilength = 0, Isize = 0;
        decimal Iquote;
        //
        Sweight = " ";
        Ssize = " ";
        Console.SetWindowSize(100, 10);
        Console.Title = "Package Quote System";
        SubQcolor();
        Console.Clear();
        Console.WriteLine("+--------------------------------------+");
        Console.WriteLine("|      Welcome to Package Express      |\n| Please follow the instructions below |");
        Console.WriteLine("+--------------------------------------+");
        //
        SubQcolor();
        Console.WriteLine("Please type your package weight:");
        SubAcolor();
        Iweight = Convert.ToInt32(Console.ReadLine());
        Sweight = Iweight > 50 ? "Package too heavy to be shipped via Package Express. Have a good day." : " ";
        if (Iweight <= 50)
        {
            SubQcolor();
            Console.WriteLine("Please type your package width:");
            SubAcolor();
            Iwidth = Convert.ToInt32(Console.ReadLine());
            //
            SubQcolor();
            Console.WriteLine("Please type your package height:");
            SubAcolor();
            Iheight = Convert.ToInt32(Console.ReadLine());
            //
            SubQcolor();
            Console.WriteLine("Please type your package length:");
            SubAcolor();
            Ilength = Convert.ToInt32(Console.ReadLine());
            //
            Isize = Iwidth + Iheight + Ilength;
            Ssize = Isize > 50 ? "Package too big to be shipped via Package Express." : " ";
        }
        if (Iweight > 50)
        {
            Console.WriteLine(Sweight);
            Console.ReadLine();
        }
        else if (Isize > 50)
        {
            Console.WriteLine(Ssize);
            Console.ReadLine();
        }
        else
        {
            Isize = Iwidth + Iheight + Ilength;
            Iquote = (Iweight * Isize) / 100;
            Console.WriteLine("Your estimated shipping quote is: $" + Iquote);
            Console.ReadLine();
        }
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