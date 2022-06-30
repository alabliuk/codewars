using System;
using System.Linq;

public static class Kata
{
    //--> https://www.codewars.com/kata/5467e4d82edf8bbf40000155
    public static void Main()
    {
        DescendingOrder(1021); //1201
        //DescendingOrder(123);
    }

    public static int DescendingOrder(int num)
    {
        var invertArray = num.ToString().ToArray().Reverse();
        string newNum = string.Empty;

        foreach(var x in invertArray)
        {
            newNum += char.GetNumericValue(x);
        }

        return Convert.ToInt32(newNum);
    }
}