using static System.Net.Mime.MediaTypeNames;

Console.Write("Введите номер месяца:");
string? monthNumber = Console.ReadLine();
int monthNumberInt;

try
{
    monthNumberInt = Convert.ToInt32(monthNumber);
    if (monthNumberInt <= 2)
    {
        Console.WriteLine("Зима");
    }
    else if (monthNumberInt <= 5)
    {
        Console.WriteLine("Весна");
    }
    else if (monthNumberInt <= 8)
    {
        Console.WriteLine("Лето");
    }
    else if (monthNumberInt <= 11)
    {
        Console.WriteLine("Осень");
    }
    else if (monthNumberInt <= 12)
    {
        Console.WriteLine("Зима");
    }
    else
    {
        Console.WriteLine("Такого месяца нет.");
    }
}
catch
{
    Console.Write("Некорректный ввод");
    Environment.Exit(0);
}