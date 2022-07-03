using System.Numerics;

public static class Kata
{
    //--> https://www.codewars.com/kata/5324945e2ece5e1f32000370
    public static void Main()
    {
        sumStrings("123", "456"); //579
    }

    public static string sumStrings(string a, string b)
    {
        BigInteger.TryParse(a, out BigInteger nA);
        BigInteger.TryParse(b, out BigInteger nB);
        return (nA + nB).ToString();
    }
}