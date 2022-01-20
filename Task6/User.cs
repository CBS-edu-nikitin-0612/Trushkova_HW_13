using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class User
    {
        string? _login;
        string? _name;
        string? _surname;
        int _age;
        readonly DateTime _date;

        public User(DateTime dateTime)
        {
            _date = dateTime;
        }

#nullable disable
        public User(string login, DateTime dateTime) : this(dateTime)
        {
            if (login != null)
            {
                this._login = login;
            }
            else
            {
                this._login = "Логин не задан";
            }
        }
#nullable restore

        public string Login
        {
            get
            {
                if (_login != null)
                {
                    return _login;
                }
                else
                {
                    return "Логин не задан";
                }
            }
            set { _login = value; }
        }

        public string Name
        {
            get
            {
                if (_name != null)
                {
                    return _name;
                }
                else
                {
                    return "Имя не задано";
                }
            }
            set { _name = value; }
        }

        public string Surname
        {
            get
            {
                if (_surname != null)
                {
                    return _surname;
                }
                else
                {
                    return "Фамилия не задана";
                }
            }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public DateTime DateTimeLogin
        {
            get { return _date; }
        }

        public void Show()
        {
            Console.WriteLine($"Пользователь {_login} c именем {_name} " +
    $"и фамилией {_surname} возраст {_age} зарегистрировался {_date}");
        }
    }
}
