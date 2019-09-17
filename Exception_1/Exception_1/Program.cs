using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> Ilist = new List<int>();
        int n1, n2; 
        //
        Ilist.Add(1);
        Ilist.Add(123);
        Ilist.Add(14);
        Ilist.Add(61);
        Ilist.Add(50);
        Ilist.Add(1024);
        Ilist.Add(256);
        Ilist.Add(777);
        //
        try
        {
            Console.WriteLine("Tye a number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Ilist.Count;i++)
            {
                n2 = Ilist[i] / n1;
                Console.WriteLine(Ilist[i] + " divide by " + n1 + " is " + n2);  
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("You cannot divide by 0."); 
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please just type numbers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
    }
}
