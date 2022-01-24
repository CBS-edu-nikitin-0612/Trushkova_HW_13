namespace Task3
{
    internal class Employee
    {
        string _name;
        string _surname;
        string _position;
        int _experience;
        double _salary;


        public Employee(string name, string surname)
        {
            this._name = name;
            this._surname = surname;
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
                    return "Имя сотрудника не задано";
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
                    return "Фамилия сотрудника не задана";
                }
            }
            set { _surname = value; }
        }

        public string Position
        {
            get
            {
                if (_position != null)
                {
                    return _position;
                }
                else
                {
                    return "Название должности не задано";
                }
            }
            set { _position = value; }
        }

        public int Experience
        { get { return _experience; } set { _experience = value; } }

        public double Salary
        {
            get
            {
                CalculateSalary();
                return _salary;
            }
            set { _salary = value; }
        }

        void CalculateSalary()
        {
            _salary = 0;

            switch (_position)
            {
                case "директор":
                    _salary = 200000;
                    break;
                case "руководитель":
                    _salary = 100000;
                    break;
                case "рядовой сотрудник":
                    _salary = 50000;
                    break;
            }

            if (_experience < 5)
            {
                _salary *= 1;
            }
            else if ((_experience >= 5) && (_experience < 10))
            {
                _salary *= 1.2;
            }
            else if ((_experience >= 10) && (_experience < 15))
            {
                _salary *= 1.4;
            }
            else if ((_experience >= 15) && (_experience < 20))
            {
                _salary *= 1.6;
            }
            else if (_experience >= 20)
            {
                _salary *= 2;
            }
        }

        public double CalculateTaxCollection(int taxProcent)
        {
            double tax;
            tax = _salary * taxProcent / 100;
            return tax;
        }

    }
}
