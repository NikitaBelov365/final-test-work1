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

string[] NewArrayLessThan3(string[] array)
{
    string[] newArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
            newArray[count] = array[i];
            count ++;
        }
    }
    Array.Resize(ref newArray, count);
    return newArray;
}

int arraySize = InputArraySize("Input array size");
string[] array = ArrayCreation(arraySize);
ArrayFill(array);
ArrayPrint(array);
string[] newArray = NewArrayLessThan3(array);
ArrayPrint(newArray);