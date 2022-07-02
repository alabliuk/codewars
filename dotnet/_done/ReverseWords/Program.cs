using System;

public static class Kata
{
    //--> https://www.codewars.com/kata/5259b20d6021e9e14c0010d4

    public static void Main()
    {
        ReverseWords("This is an example!");
    }

    public static string ReverseWords(string str)
    {
        string[] words = str.Split(' ');
        string newWords = string.Empty;

        foreach (string x in words)
        {
            newWords = newWords + ReverseChars(x) + " ";
        }

        return newWords.TrimEnd();
    }

    public static string ReverseChars(string str)
    {
        int aux = str.Length - 1;
        string newStr = string.Empty;

        for (int i = 0; i < str.Length; i++)
        {
            newStr = newStr + str[aux];
            aux--;
        }

        return newStr;
    }
}