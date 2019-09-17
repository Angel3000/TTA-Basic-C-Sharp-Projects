using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string[] Sarray = new string[5];
        string EndF = "N";
        //
        for (int i = 0; i < Sarray.Length; i++)
        {
            Console.WriteLine("Type text for index " + i);
            Sarray[i] = Console.ReadLine();
        }
        foreach (string ss in Sarray)
        {
            Console.WriteLine(ss);
        }
        //
        //
        int j = 0;
        do
        {
            Console.WriteLine(Sarray[j]);
            j++;
            if (j == 5)
            {
                Console.WriteLine("Type Y to stop");
                EndF = Console.ReadLine();
                if (!(EndF == "Y"))
                {
                    j = 0;
                }
            }
        }
        while (EndF != "Y");
        //
        //
        Console.WriteLine("Loop using <");
        int z = 0;
        do
        {
            Console.WriteLine(Sarray[z]);
            z++;
        }
        while (z < 5);
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
        //
        //
        Console.WriteLine("Loop using <=");
        z = 0;
        do
        {
            Console.WriteLine(Sarray[z]);
            z++;
        }
        while (z <= 4);
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
        //
        //
        string scolor;
        List<string> Slist = new List<string>();
        Slist.Add("blue");
        Slist.Add("red");
        Slist.Add("yellow");
        Slist.Add("green");
        Slist.Add("orange");
        //
        Console.WriteLine("Type a color:");
        scolor = Console.ReadLine().ToLower();
        int p = 0;
        for (p = 0; p < Slist.Count; p++)
        {
            if (Slist[p] == scolor)
            {
                Console.WriteLine("Color found in position " + p);
                break;
            }
        }
        if (p >= 5)
        {
            Console.WriteLine("Your color is not on the list.");
        }
        Console.ReadLine();

        //
        //
        Slist.Add("yellow");
        Slist.Add("red");
        int h = 0;
        //
        Console.WriteLine("Type a color:");
        scolor = Console.ReadLine().ToLower();
        for (h = 0; h < Slist.Count; h++)
        {
            if (Slist[h] == scolor)
            {
                Console.WriteLine("Color found in position " + h);
            }
        }
        if (!(Slist.Contains(scolor)))
         {
            Console.WriteLine("Your color is not on the list.");
        }
        Console.ReadLine();
        //
        //

        int w = 0, v = 0;
        string tmes;
        foreach (string ff in Slist)
        {
            v = Slist.IndexOf(ff);
            tmes = " is not before.";
            if (v < w)
            {
                tmes = " is before in position " + v;
            }
            Console.WriteLine("Item " + ff + " on position " + w + tmes);
            w++;
        }
        Console.ReadLine();
    }
}
