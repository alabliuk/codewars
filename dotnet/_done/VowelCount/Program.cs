using System.Text.RegularExpressions;

public static class Kata
{
    public static void Main()
    {
        GetVowelCount("abracadabra");
    }

    public static int GetVowelCount(string str)
    {
        return Regex.Matches(str, @"[aeiou]").Count;
    }
}