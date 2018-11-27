using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            string guess;
            int userGuess;

            Random ranNumberGenerator = new Random();
            randomNumber = ranNumberGenerator.Next(1, 11);

            Console.WriteLine("Guess a number between 1 and 10");
            guess = Console.ReadLine();
            userGuess = Convert.ToInt32(guess);

            if(userGuess == randomNumber)
            {
                Console.WriteLine("Correct!");
            }
            else if(userGuess > randomNumber)
            {
                Console.WriteLine("Too High!");
            }
            else if(userGuess < randomNumber)
            {
                Console.WriteLine("Too Low!");
            }
        }
    }
}
