using static System.Console;

WriteLine("Введите строки массива через запятую: ");
string[] elements = GetArray();
WriteLine("Начальный массив: ");
PrintArray(elements);
WriteLine();
WriteLine("Массив из элементов меньше трех символов: ");
string[] shortElements = CheckElements(elements);
PrintArray(shortElements);

string[] GetArray()
{
    string[] result = ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries);
    return result;
}

string[] CheckElements(string[] inArray)
{
    string[] newArray = new string[inArray.Length];
    int number = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            newArray[number] = inArray[i];
            number++;
        }
    }
    return newArray;
}

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i]} ");
    }
}