using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(39.40, 40.50, 0.45);
            Console.WriteLine("Введите количество денег в гривне");
            double uah = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите валюту (usd, eur, rub)");
            string currency = Console.ReadLine();
            Console.WriteLine(converter.ConvertUAHToCurrency(uah, currency));
            Console.WriteLine("Введите название валюты чтобы получить гривну");
            currency = Console.ReadLine();
            Console.WriteLine("Введите значение");
            double currencyValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(converter.ConvertСurrencyToUAH(currencyValue, currency));
            Console.ReadKey();
        }
    }
}
