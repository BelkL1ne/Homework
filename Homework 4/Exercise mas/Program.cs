using System.Diagnostics.CodeAnalysis;

Random random = new Random();
int negative = 0;
int positive = 0;
int temp = 0;


Console.WriteLine("Введите размерность матрицы: ");
string? size = Console.ReadLine();
int sizeInt = Convert.ToInt32(size);

int[,] arr = new int[sizeInt, sizeInt];

for (int columns = 0; columns < arr.GetLength(0); columns++)
{
    for (int rows = 0; rows < arr.GetLength(1); rows++)
    {
        arr[rows, columns] = random.Next(-10, 10);

        Console.Write($"{arr[rows,columns]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Выберете действие");
Console.WriteLine("1 - Найти количество положительных/отрицательных чисел в матрице\n2 - Сортировка элементов матрицы построчно (в двух направлениях)\n3 - Инверсия элементов матрицы построчно");

string? operation = Console.ReadLine();

switch (operation)
{
    case "1":

        for (int columns = 0; columns < arr.GetLength(0); columns++)
        {
            for (int rows = 0; rows < arr.GetLength(1); rows++)
            {
                if (arr[rows, columns] < 0)
                {
                    negative++;
                }
                else
                {
                    positive++;
                }
            }
        }
        Console.WriteLine($"В массиве {negative} отрицательных чисел и {positive} положительных.");
        break;

    case "2":
        Console.WriteLine("1 - от меньшего к большему, 2 - от большего к меньшему");
        Console.WriteLine("Введите направление сортировки: ");
        string? Sort = Console.ReadLine();

        Console.WriteLine("Введите номер строки для сортировки: ");
        string? operationSort = Console.ReadLine();
        int operationSortInt = Convert.ToInt32(operationSort) - 1;

        Console.WriteLine(arr.GetLength(0));
        switch (Sort)
        {
            case "1":
                for (int i = 0; i < arr.GetLength(operationSortInt) - 1; i++)
                {


                    for (int j = i + 1; j < arr.GetLength(operationSortInt); j++)
                    {
                        if (arr[i, operationSortInt] > arr[j, operationSortInt])
                        {
                            temp = arr[i, operationSortInt];
                            arr[i, operationSortInt] = arr[j, operationSortInt];
                            arr[j, operationSortInt] = temp;
                        }
                    }

                }
                for (int columns = 0; columns < arr.GetLength(0); columns++)
                {
                    for (int rows = 0; rows < arr.GetLength(1); rows++)
                    {
                        Console.Write($"{arr[rows, columns]} ");
                    }
                    Console.WriteLine();
                }
                break;

            case "2":
                for (int i = 0; i < arr.GetLength(operationSortInt) - 1; i++)
                {


                    for (int j = i + 1; j < arr.GetLength(operationSortInt); j++)
                    {
                        if (arr[i, operationSortInt] < arr[j, operationSortInt])
                        {
                            temp = arr[i, operationSortInt];
                            arr[i, operationSortInt] = arr[j, operationSortInt];
                            arr[j, operationSortInt] = temp;
                        }
                    }

                }
                for (int columns = 0; columns < arr.GetLength(0); columns++)
                {
                    for (int rows = 0; rows < arr.GetLength(1); rows++)
                    {
                        Console.Write($"{arr[rows, columns]} ");
                    }
                    Console.WriteLine();
                }
                break;

            default:
                Console.WriteLine("Некорректный ввод.");
                Environment.Exit(0);
                break;
        }
        break;  
        
    case "3":
        Console.WriteLine("Введите номер строки для инверсии: ");
        string? operationInversion = Console.ReadLine();
        int operationInversionInt = Convert.ToInt32(operationInversion) - 1;
        
        
        int mid = arr.GetLength(0) / 2;

        for (int i = 0; i < mid; i++)
        {
            temp = arr[i, operationInversionInt];
        
            arr[i, operationInversionInt] = arr[arr.GetLength(0) - i - 1, operationInversionInt];
           
            arr[arr.GetLength(0) - i - 1, operationInversionInt] = temp;
     
        }

        for (int columns = 0; columns < arr.GetLength(0); columns++)
        {
            for (int rows = 0; rows < arr.GetLength(1); rows++)
            {
                Console.Write($"{arr[rows, columns]} ");
            }
            Console.WriteLine();
        }
        break;
}
