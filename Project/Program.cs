using static System.Console;

string[] GetArray()
{
    string[] result = ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries);
    return result;
}