using System;
class Program
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.SetWindowSize(100, 10);
        Console.Title = "Wellcome!!!!!";
        Console.WriteLine("+-----------------------------------------+");
        Console.WriteLine("|    Welcome to Acme Accounting Systems   |");
        Console.WriteLine("|   Remember, we’re “accounting” on you!  |");
        Console.WriteLine("+-----------------------------------------+");
        Console.ReadLine();
    }
}