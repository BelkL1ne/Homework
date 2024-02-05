Console.WriteLine("Введите число: ");
string? num = Console.ReadLine();
int numInt = Convert.ToInt32(num);
int result = 0;

for (int i = 1; i <= numInt; i++)
{
    result += i;
    
    if (i == numInt)
    {
        Console.WriteLine(result);
    }
    
}
