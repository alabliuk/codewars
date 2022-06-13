using System;

public static class Kata
{
    //--> https://www.codewars.com/kata/5168bb5dfe9a00b126000018

    public static void Main()
    {
        ReversedStrings("world");
    }

    public static string ReversedStrings(string str)
    {
        char[] ch = new char[str.Length];
        int aux = str.Length - 1;
        string newStr = string.Empty;

        for (int i = 0; i < str.Length; i++)
        {
            ch[i] = str[aux];
            aux--;
        }

        foreach (char c in ch)
        {
            newStr = newStr + c;
        }

        return newStr;
    }
}