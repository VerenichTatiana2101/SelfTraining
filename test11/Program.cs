string[] stringArray = new string[] { "oldf", "two", "this", "is", "great" };

Console.WriteLine("Введите целое число элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введённый массив строк: ");
PrintArray(stringArray);
Console.WriteLine();

int size = CountSizeArray(stringArray, number);
string[] newArray = new string[size];

ShortStrings(stringArray, newArray, number);
Console.WriteLine("Результат согласно условию: ");
PrintArray(newArray);

void ShortStrings(string[] array, string[] creatArray, int num)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= num)
        {
            creatArray[j] = array[i];
            j++;
        }
    }
}

int CountSizeArray(string[] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= num)
            count++;
    }
    return count;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

// string[] Smash(string[] words)
// {
//     int j = 0;
//     string[] resultString = new string[words.Length];
//     for (int i = 0; i < words.Length; i++)
//     {
//         if (words[i].Length <= 3)
//         {
//             resultString[j] = words[i];
//             j++;
//         } 
//     }
//     Array.Resize(ref resultString, j);
//     return resultString;
// }




