public static class Kata
{
    //--> https://www.codewars.com/kata/583203e6eb35d7980400002a/
    public static void Main()
    {
        CountSmileys(new string[] { ":D", ":~)", ";~D", ":)", ";-D" });
    }

    public static int CountSmileys(string[] smileys)
    {
        int count = 0;
        string[] eyesArray = { ":", ";" };
        string[] noseArray = { "-", "~" };
        string[] mounthArray = { ")", "D" };

        foreach (var x in smileys)
        {
            if (containsInArray(x.Substring(0, 1), eyesArray))
            {
                if (x.Length == 3)
                {
                    if (containsInArray(x.Substring(1, 1), noseArray))
                        if (containsInArray(x.Substring(2, 1), mounthArray))
                            count++;
                }
                else if (x.Length == 2)
                {
                    if (containsInArray(x.Substring(1, 1), mounthArray))
                        count++;
                }
            }
        }
        return count;
    }

    public static bool containsInArray(string value, string[] array)
    {
        foreach (var x in array)
            if (x.Contains(value)) return true;
        return false;
    }
}