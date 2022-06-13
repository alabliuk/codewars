using System;

public static class Kata
{
    //--> https://www.codewars.com/kata/5a00e05cc374cb34d100000d

    public static void Main()
    {
        ReverseSeq(5);
    }

    public static int[] ReverseSeq(int n)
    {
        var seq = new int[n];
        int aux = n;

        for (int i = 0; i < n; i++)
        {
            seq[i] = aux;
            aux--;
        }

        return seq;
    }
}