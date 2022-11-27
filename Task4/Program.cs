using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(455466, "Alex", "Foxtrot")
            {
                Article = "USB-hab",
                Quantity = 6
            };

            inv.CostCalculation(true);
            inv.CostCalculation(false);

            Console.ReadKey();
        }
    }
}
