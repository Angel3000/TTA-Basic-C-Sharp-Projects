using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to the casino. Tell me your name:");
            string playerName = Console.ReadLine();
            //
            bool validAnwser = false;
            int bank = 0;
            while (!validAnwser)
            { 
                Console.WriteLine("How much money do you bring?");
                validAnwser = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnwser) Console.WriteLine("Please type digits only. No decimals.");
            }
            //           
            Console.WriteLine("Hello {0}, Would you like to join blackjack?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\angel.lopez\Desktop\VSP\TTA-Basic-C-Sharp-Projects\TwentyOne\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                //
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    { 
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Get him!");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error ocurred. Please cotact with your system administrator");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thanks for playing.");
            }

            Console.WriteLine("Feel fre to look arround");
            Console.ReadLine();
        }
    }
}
