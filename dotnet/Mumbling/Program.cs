public class Accumul
{
    //-> https://www.codewars.com/kata/5667e8f4e3f572a8f2000039

    public static void Main()
    {
        Accum("abcd"); //"A-Bb-Ccc-Dddd"
    }

    public static string Accum(string s)
    {
        char[] newArray = s.ToLower().ToCharArray();
        string accumString = string.Empty;
        int round = 1;

        foreach (var x in newArray)
        {
            var auxString = string.Empty;
            for (int i = 1; i <= round; i++)
            {
                if (i == 1)
                    auxString = x.ToString().ToUpper();
                else
                    auxString += x;
            }
            accumString += string.Concat(auxString, "-");
            round++;
        }

        return accumString.Substring(0, accumString.Length - 1);
    }
}