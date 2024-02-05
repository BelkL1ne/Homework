Random random = new Random();

int[] arr1 = new int[5];
int[] arr2 = new int[5];
double resultArr1 = 0;
double resultArr2 = 0;

Console.WriteLine("Массив №1: ");
for (int i = 0; i < arr1.GetLength(0); i++)
{
    arr1[i] = random.Next(0, 10);
    resultArr1 += arr1[i];
    Console.Write($"{arr1[i]} ");
}
resultArr1 /= arr1.GetLength(0);
Console.WriteLine($"\nСреднее арифметическое массива №1: {resultArr1} ");



Console.WriteLine("Массив №2: ");
for (int j = 0; j < arr2.GetLength(0); j++)
{
    arr1[j] = random.Next(0, 10);
    resultArr2 += arr1[j];
    Console.Write($"{arr1[j]} ");
}
resultArr2 /= arr2.GetLength(0);
Console.WriteLine($"\nСреднее арифметическое массива №2: {resultArr2} ");


if (resultArr1 > resultArr2)
{
    Console.WriteLine("\nСреднее арифметическое массива №1 больше.");
}
else if (resultArr1 < resultArr2)
{
    Console.WriteLine("\nСреднее арифметическое массива №2 больше.");
}
else
{
    Console.WriteLine("\nСреднее арифметическое массивов равны.");
}