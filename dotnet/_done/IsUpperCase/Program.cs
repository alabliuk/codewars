public static class StringExtensions
{
    public static void Main()
    {
        IsUpperCase("hello I AM DONALD"); //false  
    }

    public static bool IsUpperCase(this string text)
    {
        char[] txtArray = text.ToArray();

        foreach(var x in txtArray)
        {
            if (char.IsLower(x))
                return false;
        }

        return true;
    }
}