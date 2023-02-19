using static System.Console;

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