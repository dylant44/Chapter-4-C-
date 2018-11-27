using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            double purchasePrice;
            string price;

            Console.WriteLine("Please enter purchase price");
            price = Console.ReadLine();
            purchasePrice = Convert.ToDouble(price);

            if (purchasePrice > 5000)
                Console.WriteLine("ERROR");
            else
                Console.WriteLine("Approved");
        }
    }
}
