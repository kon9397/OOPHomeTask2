using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWork2
{
    internal class Converter
    {
        private double usd = 0;
        private double eur = 0;
        private double rub = 0;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double ConvertUAHToCurrency(double uah, string currency)
        {
            if(currency == "usd")
            {
                return uah / this.usd;
            } 
            else if (currency == "eur")
            {
                return uah / this.eur;
            } 
            else if (currency == "rub")
            {
                return uah / this.rub;
            }

            return 0;
        }

        public double ConvertСurrencyToUAH(double currencyValue, string currency)
        {
            if (currency == "usd")
            {
                return currencyValue * this.usd;
            }
            else if (currency == "eur")
            {
                return currencyValue * this.eur;
            }
            else if (currency == "rub")
            {
                return currencyValue * this.rub;
            }

            return 0;
        }
    }
}
