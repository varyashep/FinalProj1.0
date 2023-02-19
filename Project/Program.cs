using static System.Console;

string[] GetArray()
{
    string[] result = ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries);
    return result;
}

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i]} ");
    }
}