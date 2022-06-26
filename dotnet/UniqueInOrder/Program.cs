using System.Collections.Generic;

public static class Kata
{
    //--> https://www.codewars.com/kata/54e6533c92449cc251001667

    public static void Main()
    {
        UniqueInOrder("AAAABBBCCDAABBB");
    }

    public static int UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        var uniqueOrder = new string[] { };

        foreach (var x in iterable)
        {
            uniqueOrder[1] = x.ToString();
        }

        return 1;
    }
}