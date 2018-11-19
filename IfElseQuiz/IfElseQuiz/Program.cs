using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IfElseQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            string userChoiceString;
            WriteLine("Please enter a number: 1, 2, or 3");
            userChoiceString = ReadLine();
            userChoice = Convert.ToInt32(userChoiceString);

            if(userChoice == 1 || userChoice == 3)
            {
                WriteLine("You Lose!");
            }
            else if(userChoice == 2)
            {
                WriteLine("You Win!");
            }
            else
            {
                WriteLine("ERROR");
            }

        }
    }
}
