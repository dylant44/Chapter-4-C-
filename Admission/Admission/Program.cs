using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double gpa;
            string Gpa;
            double testScore;
            string TestScore;
            Console.WriteLine("Please enter your gpa");
            Gpa = Console.ReadLine();
            gpa = Convert.ToDouble(Gpa);

            Console.WriteLine("Please enter your admission test score");
            TestScore = Console.ReadLine();
            testScore = Convert.ToDouble(TestScore);

            if(gpa >= 3 && testScore >= 60)
            {
                Console.WriteLine("Accept");
            }
            else if(gpa < 3 && testScore >= 80)
            {
                Console.WriteLine("Accept");
            }
            else
            {
                Console.WriteLine("Reject");
            }

        }
    }
}
