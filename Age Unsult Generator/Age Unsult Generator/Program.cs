using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Age_Unsult_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int yes;
            string yesString;
            string ageString;
            Write("Welcome to the famous Age Insult Generator!!!");
            Write("Please enter your age");
            ageString = ReadLine();
            age = Convert.ToInt32(ageString);

            if (age < 19)
            {
                Write("You are a minor");
            }
            else if (age >= 18 && age < 25)
            {
                Write("You should be in college or done with college by now. dont be a deadbeat");
            }
            else if (age >= 25 && age < 32)
            {
                Write("Do you have a job? 1 for yes 2 for no");
                yesString = ReadLine();
                yes = Convert.ToInt32(yesString);
                if (yes == 1)
                {
                    Write("Good for you");
                }
                else
                {
                    Write("Get a job hippie");
                }

            if(age >= 32 && age < 42)
                {
                    Write("You are getting old");
                }
            else if(age >= 42 && age < 52)
                {
                    Write("You are getting really old");
                }
            else if(age >= 52 && age < 62)
                {
                    Write("Dude you're ancient");
                }
            else if(age >= 62)
                {
                    Write("get off your grandkids computer");
                }
             
                
            }

        }
    }
}
