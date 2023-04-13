// Deoxyribonucleic acid, DNA is the primary information storage molecule in biological systems. 
// It is composed of four nucleic acid bases Guanine ('G'), Cytosine ('C'), Adenine ('A'), and Thymine ('T').
// Ribonucleic acid, RNA, is the primary messenger molecule in cells. 
// RNA differs slightly from DNA its chemical structure and contains no Thymine. 
// In RNA Thymine is replaced by another nucleic acid Uracil ('U').
// Create a function which translates a given DNA string into RNA.
// For example:
// "GCAT"  =>  "GCAU"
// The input string can be of arbitrary length - in particular, 
// it may be empty. All input is guaranteed to be valid, 
// i.e. each input string will only ever consist of 'G', 'C', 'A' and/or 'T'.

string text = "GCAT";
string newText = dnaToRna(text, 'T', 'U');
Console.WriteLine(newText);
Console.WriteLine();

string dnaToRna(string dna, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string text2 = "GCAT";
Console.WriteLine(text2);
string newText2 = dnaToRna2(text2);
Console.WriteLine(newText2);

string dnaToRna2(string dna)
{
    return dna.Replace('T', 'U');
}
