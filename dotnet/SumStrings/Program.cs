using System;
public static class Kata
{
    //--> https://www.codewars.com/kata/5324945e2ece5e1f32000370
    public static void Main()
    {
        sumStrings("123", "456"); //579
    }

    public static string sumStrings(string a, string b)
    {
        var x = Convert.ToUInt32(a) + Convert.ToUInt32(b);
        return x.ToString();
    }
}