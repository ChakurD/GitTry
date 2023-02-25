using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfoStruct
{
    struct UserInfo
    {
        public string name ;
        public int age ;
        public string addres ;
        public string surname ;
        public string login ;
        public string password ;

        public UserInfo()
        {
            Console.WriteLine("Введите имя пользователя:");
             name = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя:");
             age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите адрес пользователя:");
             addres = Console.ReadLine();
            Console.WriteLine("Введите фамилию пользователя:");
            surname = Console.ReadLine();
            Console.WriteLine("Введите логин пользователя:");
             login = Console.ReadLine();
            Console.WriteLine("Введите пароль пользователя:");
             password = Console.ReadLine();
        }
        public void ShowUserInfo()
        {
            Console.WriteLine($"Имя пользователя: {name}\nФамилия пользователя: {age}\nВозраст пользователя: {addres}\nАдрес пользователя: {surname}\nЛогин пользователя: {login}\nПароль пользователя: {password}");
        }
    }
}
