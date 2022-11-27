using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class User
    {
        private string login;
        private string name;
        private int age;
        private readonly DateTime date;

        public User(string login, string name, int age)
        {
            this.login = login;
            this.name = name;
            this.age = age;
            this.date = DateTime.Now;
        }

        public void GetUserInfo()
        {
            Console.WriteLine($"Логин:{login}\nИмя:{name}\nВозраст:{age}\nДата:{date}");
        }
    }
}
