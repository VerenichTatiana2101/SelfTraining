// Your task is to make two functions 
// ( max and min, or maximum and minimum, etc., depending on the language ) 
// that receive a list of integers as input, 
// and return the largest and lowest number in that list, respectively.
// Examples (Input -> Output)
// * [4,6,2,1,9,63,-134,566]         -> max = 566, min = -134
// * [-52, 56, 30, 29, -54, 0, -110] -> min = -110, max = 56
// * [42, 54, 65, 87, 0]             -> min = 0, max = 87
// * [5]                             -> min = 5, max = 5

int[] array = ArrayRndInt(10, 99, 1000);
PrintArray(array);

int minimal = Min(array);
int maximal = Max(array);
Console.WriteLine();
Console.WriteLine($"-> min = {minimal}, max = {maximal}");

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

int Min(int[] list)
{
    int min = list[0];
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] < min) min = list[i];
    }
    return min;
}

int Max(int[] list)
{
    int max = list[0];
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] > max) max = list[i];
    }
    return max;
}


// public class Kata
// {
//   public int Min(int[] list)
//     {
//        int min = list[0];
//        for (int i = 0; i < list.Length; i++)
//             {
//                 if (list[i] < min) min = list[i];
//             }
//        return min;
//     }

//   public int Max(int[] list)
//     {
//     int max = list[0];
//     for (int i = 0; i < list.Length; i++)
//        {
//            if (list[i] > max) max = list[i];
//       }
//     return max;
//     }
// }