using System;

public class Kata
{
    //--> https://www.codewars.com/kata/544675c6f971f7399a000e79

    public static void Main()
    {
        StringToNumber("1234");
    }


    public static int StringToNumber(string str)
    {
        return int.Parse(str);
    }
}