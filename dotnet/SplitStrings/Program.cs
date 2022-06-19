public class SplitString
{
    //--> https://www.codewars.com/kata/515de9ae9dcfc28eb6000001

    public static void Main()
    {
        Solution("abcde");
    }

    public static string[] Solution(string str)
    {
        string[] x;
        if (str.Length % 2 == 0)
        {
            x = new string[(str.Length / 2)];
        }
        else
        {
            x = new string[((str.Length / 2) + 1)];
        }

        for (int i = 0; i < x.Length; i++)
        {
            if (str.Length > 1)
            {
                x[i] += str.Substring(0, 2);
                str = str.Substring(2);
            }
            else
            {
                x[i] += string.Concat(str.Substring(0, 1), "_");
            }
        }

        return x;
    }
}