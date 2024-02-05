using System.ComponentModel.Design;

Console.Write("Введите температуру:");
string? tempreture = Console.ReadLine();
int tempretureInt;

try
{
    tempretureInt = Convert.ToInt32(tempreture);

    if (tempretureInt > -5)
    {
        Console.WriteLine("Тепло");
    }
    else if (tempretureInt <= -5 && tempretureInt > -20)
    {
        Console.WriteLine("Нормально");
    }
    else if (tempretureInt <= -20)
    {
        Console.WriteLine("Холодно");
    }
}
catch
{
    Console.Write("Некорректный ввод");
    Environment.Exit(0);
}