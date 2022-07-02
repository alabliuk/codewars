using System;

public class Kata
{
    public static void Main()
    {
        Remove_char("");
    }

    public static string Remove_char(string s)
    {
        if (s.Length < 2)
            return string.Empty;

        return s.Remove(s.Length - 1).Substring(1);
    }
}