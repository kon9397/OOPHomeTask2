using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Employee
    {
        private readonly string firstName, lastName;
        private string profession;
        private readonly int incomeTaxPercent = 18;
        private int experience;
        private int income = 0;
        private int tax = 0;

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }

        public string Profession
        {
            get
            {
                if (profession == null)
                {
                    return "Профессия неизвестна";
                }
                return profession;
            }
            set
            {
                profession = value;
                this.setIncomeByDefault();
            }
        }

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
                ChangeIncomeByExperience();
            }
        }

        public int Income { 
            get {
                return income;
            } 
        }

        public int Tax
        {
            get
            {
                this.tax = this.income * this.incomeTaxPercent / 100;
                return tax;
            }
        }

        private void setIncomeByDefault()
        {
            if(profession == null)
            {
                return;
            }

            if(profession == "Программист")
            {
                income = 30000;
            } else if (profession == "HR") 
            {
                income = 12000;
            } else if (profession == "Бухгалтер")
            {
                income = 17000;
            } else if(profession == "Уборщик")
            {
                income = 8000;
            }
        }

        private void ChangeIncomeByExperience()
        {
            int premiumPercent = 0;
            int premium = 0;
            if(experience == 0)
            {
                return;
            }
            else if(experience > 1 && experience < 5)
            {
                premiumPercent = 10;
                premium = this.income * premiumPercent / 100;
                this.income += premium;
            } else if(experience >= 5 && experience < 10)
            {
                premiumPercent = 15;
                premium = this.income * premiumPercent / 100;
                this.income += premium;
            } else if(experience >= 10 && experience < 15)
            {
                premiumPercent = 20;
                premium = this.income * premiumPercent / 100;
                this.income += premium;
            } else if(experience >= 15 && experience < 20)
            {
                premiumPercent = 25;
                premium = this.income * premiumPercent / 100;
                this.income += premium;
            } else
            {
                premiumPercent = 30;
                premium = this.income * premiumPercent / 100;
                this.income += premium;
            }
        }
    }
}
