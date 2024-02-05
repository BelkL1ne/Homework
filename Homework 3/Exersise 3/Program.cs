Console.Write("Введите число:");
string? number = Console.ReadLine();
int numberInt;

try
{
    numberInt = Convert.ToInt32(number);
    
    if (numberInt % 2 == 0)
    {
        Console.WriteLine("Число чет ");
    }
    else
    {
        Console.WriteLine("Число нечет ");
    }

}
catch
{
    Console.Write("Некорректный ввод");
    Environment.Exit(0);
}