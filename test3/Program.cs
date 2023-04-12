//Consider an array/list of sheep where some sheep may be missing from their place. 
//We need a function that counts the number of sheep 
//present in the array (true means present).
//For example,
//[true,  true,  true,  false,
//  true,  true,  true,  true ,
//  true,  false, true,  false,
//  true,  false, false, true ,
//  true,  true,  true,  true ,
//  false, false, true,  true]

bool[] sheeps = ArrayRndInt(10);
PrintArray(sheeps);
Console.WriteLine();

int res = CountSheeps(sheeps);
Console.WriteLine(res);

int CountSheeps(bool[] sheeps)
{
    int count = 0;
    for (int i = 0; i < sheeps.Length; i++)
    {
        if (sheeps[i] == true) count++;
    }
    return count;
}

bool[] ArrayRndInt(int size)
{
    bool[] arr = new bool[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(2) == 1;
    }
    return arr;
}

void PrintArray(bool[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

// public static class Kata
// {
//   public static int CountSheeps(bool[] sheeps)
//   {
//     int count = 0;
//     for(int i = 0; i< sheeps.Length; i++)
//       {
//          if (sheeps[i] == true) count++;
//       }
//     return count;
//    }
// }