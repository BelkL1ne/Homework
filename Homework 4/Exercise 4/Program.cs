//int num = 0;
//while (num < 98)
//{
//    num += 7;
//    Console.Write($"{num} ");
//}

int i = 0;
while(i < 98)
{
    ++i;

    if (i % 7 == 0)
    {
        Console.Write($"{i} ");
    }
}
