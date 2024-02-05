Console.Write("Введите номер цвета радуги:");
string? colorNumber = Console.ReadLine();

switch (colorNumber)
{
    case "1":
        Console.WriteLine("Красный");
        break;

    case "2":
        Console.WriteLine("Оранжевый");
        break;

    case "3":
        Console.WriteLine("Желтый");
        break;

    case "4":
        Console.WriteLine("Зеленый");
        break;

    case "5":
        Console.WriteLine("Голубой");
        break;

    case "6":
        Console.WriteLine("Синий");
        break;

    case "7":
        Console.WriteLine("Фиолетовый");
        break;

    default:
        Console.WriteLine("Некорректный ввод");
        break;
}