﻿// Note: This kata is inspired by Convert a Number to a String!. 
// Try that one too.
// Description
// We need a function that can transform a string into a number. 
// What ways of achieving this do you know?
// Note: Don't worry, all inputs will be strings, 
// and every string is a perfectly valid representation of an integral number.
// "1234" --> 1234
// "605"  --> 605
// "1405" --> 1405
// "-7" --> -7

string number = "1405";
int res = StringToNumber(number);
Console.WriteLine(res);

int StringToNumber(string str)
{
    int num = int.Parse(str);
    return num;
}