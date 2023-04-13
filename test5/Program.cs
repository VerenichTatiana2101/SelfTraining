// Write a function which calculates the average
// of the numbers in a given list.
//Note: Empty arrays should return 0.

double[] array = CreateArrayRndDouble(5, -5, 5);
PrintArray(array);
Console.WriteLine();

double result = FindAverage(array);
Console.WriteLine($"Среднее арифметическое массива -> {Math.Round(result, 2)}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double FindAverage(double[] array)
{
    if (array.Length > 0)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }
    else return 0;
}

// class AverageSolution
// {
//     public static double FindAverage(double[] array)
//     {
//         if (array.Length > 0)
//         {
//             double sum = 0;
//             for (int i = 0; i < array.Length; i++)
//             {
//                 sum += array[i];
//             }
//             return sum / array.Length;
//         }
//         else return 0;
//     }
// }