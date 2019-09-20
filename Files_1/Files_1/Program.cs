using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files_1
{
    class Program
    {
        static void Main()
        {
            string anwser;
            do
            {
                Console.WriteLine("Please enter a number:");
                string num = Console.ReadLine();
                //
                using (StreamWriter file = new StreamWriter(@"C:\Users\angel.lopez\Desktop\VSP\TTA-Basic-C-Sharp-Projects\Files_1\log.txt", true))
                {
                    file.WriteLine(num);
                }
                Console.WriteLine("Number added to file. Do you want to add more?(Y/N)");
                anwser = Console.ReadLine().ToUpper();
            } while (anwser == "Y");
            //
            string[] lines = File.ReadAllLines(@"C:\Users\angel.lopez\Desktop\VSP\TTA-Basic-C-Sharp-Projects\Files_1\log.txt");
            Console.WriteLine("\n\nThis is what you typed:");
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
