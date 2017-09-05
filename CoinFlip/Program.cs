using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            Random numberGenerator = new Random();

            //query user
            Console.Write("enter your guess, Heads or Tails (H or T): ");
            userGuess = Console.ReadLine();

            //get random number
            coin = numberGenerator.Next(0, 2);
            if (coin == 0 && userGuess == "T")
            {
                Console.WriteLine("The flip was Tails, you win!!!");
            }
            else if (coin == 1 && userGuess == "H")
            {
                Console.WriteLine("The flip was Heads, you win!!!");
            }
            else if (coin == 0 && userGuess == "H")
            {
                Console.WriteLine("Sorry, the flip was Tails...you lose.");
            }
            else
            {
                Console.WriteLine("Sorry, the flip was Heads...you lose.");
            }
        }
    }
}
