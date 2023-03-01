using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoginPassword
{
    class UserRegistration
    {
        public static bool UserRegistrationIn(string login, string password, string confirmPassword) 
        {
            bool registrationSuccses = true;
            var NumArr = new Char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            if (login.Length >= 20) throw new WrongLoginException("Длина Логина должна быть меньше 20 символов");
            if (login.Contains(' ')) throw new WrongLoginException("Логин не должен содержать пробелы");
            if (password.Length >= 20) throw new WrongPasswordException("Длина Пароля не должна превышать 20 символов");
            if (password.Contains(' ')) throw new WrongPasswordException("Пароль не должен содержать пробелы");
            if (password.LastIndexOfAny(NumArr) == -1) throw new WrongPasswordException("Пароль должен содержить хотя 1 цифру");
            if (!password.Equals(confirmPassword)) throw new WrongPasswordException("Пароли не совпадают");
            return registrationSuccses;
        }
    }
}
