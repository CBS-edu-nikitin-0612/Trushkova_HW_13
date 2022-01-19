// See https://aka.ms/new-console-template for more information
using Task4;

Console.WriteLine("Hello, Teacher!");

int account = 123;
string customer = "Олежа";
string provider = "Барыга";

Invoice invoice = new Invoice(account, customer, provider);
invoice.Quantity = 12;
invoice.Article = "Автомобиль";

invoice.CalculateTotalPrice();

Console.WriteLine($"{invoice.Customer} купил у компании {invoice.Provider} " +
    $"{invoice.Quantity} {invoice.Article}.\n" +
    $"Сумма оплаты составила {invoice.TotalPrice} рублей с НДС и " +
    $"{invoice.TotalPriceWithoutNDS} рублей без НДС.");