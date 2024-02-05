using System;
using System.Text.RegularExpressions;

try
{
    Console.WriteLine("1 - Сложение\r\n2 - Вычитание\r\n3 - Деление\r\n4 - Умножение\r\n5 - Процент от числа\r\n6 - Квадратный корень числа\r\n7 - Отображение результата");
    Console.Write("Введите число: ");
    double a = Convert.ToDouble(Console.ReadLine());
    


    while (true)
    {
        Console.Write("Введите номер операции: ");
        string? operation = Console.ReadLine();

        Console.Write("Введите число: ");
        double b = Convert.ToDouble(Console.ReadLine());
  
        switch (operation)
        {
            case "1":
                a += b;
                break;

            case "2":
                a -= b;
                break;

            case "3":
                a /= b;
                break;

            case "4":
                a *= b;               
                break;

            case "5":
                Console.WriteLine((a / 100) * b);
                break;

            case "6":
                Console.WriteLine(Math.Sqrt(a));
                break;

            case "7":
                Console.WriteLine(a);
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Некорректный ввод");
                break;
        }
    }
}
catch
    {
        Console.Write("Некорректный ввод");
        Environment.Exit(0);
    }