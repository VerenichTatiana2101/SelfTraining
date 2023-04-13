// It's pretty straightforward. 
// Your goal is to create a function that removes the first and last characters of a string. 
// You're given one parameter, the original string. 
// You don't have to worry with strings with less than two characters.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,";
Console.WriteLine(text);
string res = RemoveChar(text);
Console.WriteLine(res);

string RemoveChar(string s)
{
    s = s.Remove(0, 1);   
    s = s.Remove(s.Length - 1, 1);
    return s;
}
