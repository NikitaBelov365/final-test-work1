int InputArraySize(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

string[] ArrayCreation(int arraySize)
{
    string[] array = new string[arraySize];
    return array;
}

void ArrayFill(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Input {i} word of new array");
        array[i] = Console.ReadLine();
    }
}

void ArrayPrint(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"{array[i]}, ");
    }
}