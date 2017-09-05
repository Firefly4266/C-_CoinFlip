using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Refactor to remove verbose conditional.
namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            string coinDescription;
            Random numberGenerator = new Random();

            //query user
            Console.Write("enter your guess, Heads or Tails (H or T): ");
            userGuess = Console.ReadLine();

            //get random number
            coin = numberGenerator.Next(0, 2);
            if (coin == 1)
            {
                coinDescription = "Heads";
            }
            else
            {
                coinDescription = "Tails";
            }

            if (coin == 0 && userGuess == "T" || coin == 1 && userGuess == "H")
            {
                Console.WriteLine("The flip was {0}, you win!!!", coinDescription);
            }
            else
            {
                Console.WriteLine("Sorry, the flip was {0}...you lose.", coinDescription);
            }
        }
    }
}
