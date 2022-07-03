using System;
using System.Text;

class LcsClass
{
    //--> https://www.codewars.com/kata/593ff8b39e1cc4bae9000070
    public static void Main()
    {
        Lcs("anothertest", "notatest"); //nottest
    }

    public static string Lcs(string a, string b)
    {
        var minorArray = new char[] { };
        var mainArray = new char[] { };
        var lcsString = string.Empty;

        if (a.Length > b.Length)
        {
            minorArray = b.ToArray();
            mainArray = a.ToArray();
        }
        else
        {
            minorArray = a.Distinct().ToArray();
            mainArray = b.Distinct().ToArray();
        }

        foreach (var x in minorArray)
        {
            if (mainArray.Contains(x))
                lcsString += x;
        }

        return lcsString; // do it!
    }
}