// See https://aka.ms/new-console-template for more information
using Task6;

Console.WriteLine("Hello, Teacher!");

User user = new User("Julyalya", new DateTime());
user.Name = "Julia";
user.Age = 32;
user.Surname = "Lol";

Console.WriteLine($"Пользователь {user.Login} c именем {user.Name} " +
    $"и фамилией {user.Surname} возраст {user.Age} зарегистрировался {user.DateTimeLogin}");

