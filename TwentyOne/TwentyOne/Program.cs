using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is a text line";
            //File.WriteAllText(@"C:\Users\angel.lopez\Desktop\VSP\TTA-Basic-C-Sharp-Projects\TwentyOne\log.txt", text);
            //
            //string text = File.ReadAllText(@"C:\Users\angel.lopez\Desktop\VSP\TTA-Basic-C-Sharp-Projects\TwentyOne\log.txt");
            //Console.WriteLine(text);
            //
            Console.WriteLine("Wellcome to the casino. Tell me your name:");
            string playerName = Console.ReadLine();

            Console.WriteLine("How much money do you bring?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello {0}, Would you like to join blackjack?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks for playing.");
            }

            Console.WriteLine("Feel fre to look arround");
            Console.ReadLine();
        }
    }
}
