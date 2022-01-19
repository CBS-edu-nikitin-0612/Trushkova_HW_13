// See https://aka.ms/new-console-template for more information
using Task3;

Console.WriteLine("Hello, World!");

Employee employee = new Employee("Антон", "Иванов");
employee.Position = "руководитель";
employee.Experience = 12;

int taxProcent = 35; //в процентах

Console.WriteLine($"Сотрудник {employee.Name} {employee.Surname} " +
    $"имеет должность {employee.Position} и зарплату {employee.Salary} рублей. \n" +
    $"Налоговый сбор для него составляет {employee.CalculateTaxCollection(taxProcent)} рублей");