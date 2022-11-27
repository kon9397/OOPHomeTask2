using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string employeeFirstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string employeeLastName = Console.ReadLine();
            Employee employee = new Employee(employeeFirstName, employeeLastName);
            Console.WriteLine("Введите должность (Программист, HR, Бухгалтер, Уборщик)");
            employee.Profession = Console.ReadLine();
            Console.WriteLine("Введите стаж");
            employee.Experience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Имя: {employee.FirstName}\nФамилия: {employee.LastName}\nПрофессия: {employee.Profession}\nОклад: {employee.Income}\nПодоходный налог: {employee.Tax}");

            Console.ReadKey();
        }
    }
}
