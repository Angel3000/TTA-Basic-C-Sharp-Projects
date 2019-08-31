using System;
class Program
{
    static void Main(string[] args)
    {
        //  Variables //
        string Scourse, Shelp, Scomments, Sfeed, Spage, Shours;
        int Ipage;
        decimal Dhours;
        bool Bhelp, Bval;
        //
        Console.SetWindowSize(100, 10);
        Console.Title = "Student Rerport";
        SubQcolor();
        Console.Clear();
        Console.WriteLine("+---------------------------------------------+");
        Console.WriteLine("|        Welcome to The Tech Academy          |");
        Console.WriteLine("+---------------------------------------------+");
        Console.WriteLine("|            Student Daily Report             |");
        Console.WriteLine("+---------------------------------------------+");
        //
        do
        {
            SubQcolor();
            Console.WriteLine("What course are you on?");
            SubAcolor();
            Scourse = Console.ReadLine();
        } while (string.IsNullOrEmpty(Scourse));
        //
        do
        {
            SubQcolor();
            Console.WriteLine("What page number?");
            SubAcolor();
            Spage = Console.ReadLine();
            Bval = false;
            Bval = int.TryParse(Spage, out Ipage);
        } while (!Bval);
        //
        do
        {
            SubQcolor();
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            SubAcolor();
            Shelp = Console.ReadLine();
            Bval = false;
            Bval = Boolean.TryParse(Shelp, out Bhelp);
        } while (!Bval);
        //
        do
        {
            SubQcolor();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            SubAcolor();
            Scomments = Console.ReadLine();
        } while (string.IsNullOrEmpty(Scomments));
        //
        do
        {
            SubQcolor();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            SubAcolor();
            Sfeed = Console.ReadLine();
        } while (string.IsNullOrEmpty(Sfeed));
        do
        {
            SubQcolor();
            Console.WriteLine("How many hours did you study today?");
            SubAcolor();
            Shours = Console.ReadLine();
            Bval = false;
            Bval = Decimal.TryParse(Shours, out Dhours);
        } while (!Bval);
        //
        //
        SubQcolor();
        Console.WriteLine("Course.......:" + Scourse);
        Console.WriteLine("Page Number..:" + Spage);
        Console.WriteLine("Need Help....:" + Shelp);
        Console.WriteLine("Comments.....:" + Scomments);
        Console.WriteLine("Feedback.....:" + Sfeed);
        Console.WriteLine("Study Hours..:" + Shours);
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
        Console.ReadLine();
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