//Complete the square sum function so that it squares 
//each number passed into it and then sums the results together.
//Завершите функцию квадратной суммы, чтобы она 
//возводила в квадрат каждое переданное ей число, а затем суммировала результаты.

int[] array = ArrayRndInt(4, 0, 5);
PrintArray(array);

Console.WriteLine();
int res = SquareSum(array);
Console.WriteLine(res);

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

int SquareSum(int[] numbers)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result += numbers[i] * numbers[i];
    }
    return result;
}

// public static class Kata
// {
//   public static int SquareSum(int[] numbers)
//   { 
//     int result = 0;
//     for(int i= 0; i< numbers.Length; i++)
//       {
//          result += numbers[i] * numbers[i];
//       }
//     return result;
//   }
// }
