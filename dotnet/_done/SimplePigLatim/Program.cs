public class Kata
{
    //--> https://www.codewars.com/kata/520b9d2ad5c005041100000f/

    public static void Main()
    {
        PigIt("Pig latin is cool !");
    }

    public static string PigIt(string str)
    {
        var newStr = string.Empty;

        foreach (var x in str.Split(" "))
        {
            if (char.IsLetter(x, 0))
                newStr += PigFunction(x);
            else
                newStr += x;
        }

        return newStr.TrimEnd();
    }

    public static string PigFunction(string str)
    {
        return string.Concat(str.Substring(1), str.Substring(0, 1), "ay ");
    }
}