using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int Iop = 0;
        string[] Sarray = new string[5];
        int[] Iarray = new int[] { 100, 111, 222, 333, 444 };
        List<string> Slist = new List<string>(); 
        //
        //
        Sarray[0] = "Posicion 0";
        Sarray[1] = "Posicion 1";
        Sarray[2] = "Posicion 2";
        Sarray[3] = "Posicion 3";
        Sarray[4] = "Posicion 4";
        //
        Slist.Add("First Item");
        Slist.Add("Second Item");
        Slist.Add("Third Item");
        Slist.Add("Fourth Item");
        Slist.Add("Fifth Item");
        //
        //
        Console.WriteLine("Type an occurence:");
        Iop = Convert.ToInt32(Console.ReadLine());
        while (Iop < 1 || Iop > 5)
        {
            Console.WriteLine("Type an occurence between 1 and 5:");
            Iop = Convert.ToInt32(Console.ReadLine());
        }
        Iop--;
        Console.WriteLine(Sarray[Iop]);
        // Console.ReadLine();
        //
        //
        Iop = 9;
        Console.WriteLine("Type an index:");
        Iop = Convert.ToInt32(Console.ReadLine());
        while (Iop < 0 || Iop > 4)
        {
            Console.WriteLine("Type an index between 0 and 4:");
            Iop = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(Iarray[Iop]);
        //Console.ReadLine();
        //
        //
        Iop = 9;
        Console.WriteLine("Type an index for the list:");
        Iop = Convert.ToInt32(Console.ReadLine());
        while (Iop < 0 || Iop > 4)
        {
            Console.WriteLine("Type an index between 0 and 4:");
            Iop = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(Slist[Iop]);
        Console.ReadLine();
    }
}
