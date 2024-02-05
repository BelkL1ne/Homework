using System;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Введите строку");
string? text = Console.ReadLine();
char[] delimiterChars = [' ', ',', '.', ':', '\t'];
string[] textArray = text.Split(delimiterChars);

GetMaxNum(textArray);
GetMaxWord(textArray);

static void GetMaxNum(string[] textArray)
{
    int index = 0;
    int numCount = 0;
    int[] charArray = new int[textArray.Length];
    int maxLenght = textArray.Length;

    for (int i = 0; i < textArray.Length; i++)
    {
        
        char[] charInWordArray = textArray[i].ToCharArray();

        foreach (char num in charInWordArray)
        {
            if (Char.IsDigit(num))
            {
                numCount++;
            }
            
        }
        charArray[i] = numCount;
        int maxNum = charArray.Max();
        for(int k = 0; k < charArray.Length; k++)
        {
            if(maxNum == charArray[k])
            {
                index = k;
            }
        }    
    }

    var isStringEqual = string.Equals(textArray[index], textArray[maxLenght - 1], StringComparison.OrdinalIgnoreCase);
    if (isStringEqual)
    {
        Console.WriteLine("В предложении нет цифр.");
    }
    else
    {
        Console.WriteLine($"Слово с самым большим количеством чисел \"{textArray[index]}\" ");
    }    

    return;
}
static void GetMaxWord(string[] textArray)
{
    string longestWord = string.Empty;
    int maxWordLength = 0;
    int occurrences = 0;
    int index = 0;

    foreach (var word in textArray)
    {
        int wordLength = word.Length;

        if (wordLength > maxWordLength)
        {
            longestWord = word;
            maxWordLength = wordLength;
            occurrences = 1;
        }
        else if (wordLength == maxWordLength && string.Equals(word, longestWord, StringComparison.OrdinalIgnoreCase))
        {
            occurrences++;
        }
    }
    for (int i = 0; i < textArray.Length; i++)
    {
        if (textArray[i] == longestWord)
        {
            index = i; 
        }
    }

    Console.WriteLine($"Слово, в котором больше всего букв \"{textArray[index]}\", оно повторяется {occurrences} раз.");
    return;
}
