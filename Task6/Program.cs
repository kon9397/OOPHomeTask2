using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            int age = Convert.ToInt32(Console.ReadLine());

            User user = new User(login, name, age);
            user.GetUserInfo();

            Console.ReadKey();
        }
    }
}
