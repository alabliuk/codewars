using System.Numerics;

public class Kata
{
    //--> https://www.codewars.com/kata/57a083a57cb1f31db7000028

    public static void Main()
    {
        PowersOfTwo(0);
    }

    public static BigInteger[] PowersOfTwo(int n)
    {
        var array = new BigInteger[n + 1];

        for (int i = 0; i <= n; i++)
        {
            array[i] = (BigInteger)Math.Pow(2, i);
        }

        return array;
    }
}