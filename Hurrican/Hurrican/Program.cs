using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurrican
{
    class Program
    {
        static void Main(string[] args)
        {
            string WindSpeed;
            int windSpeed;

            Console.WriteLine("Please enter the wind speed");
            WindSpeed = Console.ReadLine();
            windSpeed = Convert.ToInt32(WindSpeed);

            if(windSpeed >= 157)
            {
                Console.WriteLine("Category 5 Hurricane");
            }
            else if(windSpeed >= 130)
            {
                Console.WriteLine("Category 4 Hurricane");
            }
            else if (windSpeed >= 111)
            {
                Console.WriteLine("Category 3 Hurricane");
            }
            else if (windSpeed >= 96)
            {
                Console.WriteLine("Category 2 Hurricane");
            }
            else if (windSpeed >= 74)
            {
                Console.WriteLine("Category 1 Hurricane");
            }
            else if (windSpeed < 74)
            {
                Console.WriteLine("Storm Is Not A Hurricane");
            }

        }
    }
}
