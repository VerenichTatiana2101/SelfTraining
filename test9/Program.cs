// Given an array of integers your solution should find the smallest integer.
// For example:
// Given [34, 15, 88, 2] your solution will return 2
// Given [34, -345, -1, 100] your solution will return -345
// You can assume, for the purpose of this kata, 
// that the supplied array will not be empty.

int[] array = ArrayRndInt(10, -50, 50);
PrintArray(array);

int minimal = FindSmallestInt(array);
Console.WriteLine();
Console.WriteLine($"-> min = {minimal}");

int[] ArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int FindSmallestInt(int[] args)
{
    int min = args[0];
    for (int i = 0; i < args.Length; i++)
    {
        if (args[i] < min) min = args[i];
    }
    return min;
}