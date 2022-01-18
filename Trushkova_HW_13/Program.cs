// See https://aka.ms/new-console-template for more information
using Trushkova_HW_13;

Console.WriteLine("Hello, Teacher!");

double euroToGrivna = 32.05d;
double usdToGrivna = 28.25d;
double rubToGrivna = 0.355d;
Converter converter = new Converter(usdToGrivna, euroToGrivna, rubToGrivna);

double usd = 100;
Console.WriteLine($"{usd} долларов равно {converter.UsdToGrivna(usd)} гривен");

double euro = 100;
Console.WriteLine($"{euro} евро равно {converter.EurToGrivna(euro)} гривен");

double rub = 100;
Console.WriteLine($"{rub} рублей равно {converter.RubToGrivna(rub)} гривен");

double grivna = 100;
Console.WriteLine($"{grivna} гривен равно {converter.GrivnaToUsd(grivna)} долларов, " +
    $"{converter.GrivnaToEur(grivna)} евро и {converter.GrivnaToRub(grivna)} рублей");