using System.Text.RegularExpressions;

public static class Kata
{
    public static void Main()
    {
        GetVowelCount("abracadabrae");
    }

    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        vowelCount = Regex.Matches(str, @"[aeiou]").Count;

        return vowelCount;
    }
}