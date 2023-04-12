// перевенуть строку
//Reverse метод, 1.преобразовать строку в массив символов с помощью метода ToCharArray,
//2. затем вызвать метод Reverse на этом массиве. 
//После этого нужно преобразовать массив символов обратно в строку с помощью String.

static string Solution(string str)
{
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    return new String(arr);
}

string s = "world";
Console.WriteLine(Solution(s));

// using System;

// public static class Kata
// {
//   public static string Solution(string str) 
//   {
//     char[] arr = str.ToCharArray();
//     Array.Reverse(arr);
//     return new String(arr);
//   }
// }

// string s = "world";
// Console.WriteLine(Kata.Solution(s));
