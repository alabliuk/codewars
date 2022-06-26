public class StripCommentsSolution
{
    //-> https://www.codewars.com/kata/51c8e37cee245da6b40000bd

    public static void Main()
    {
        StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }); //-> apples, pears\ngrapes\nbananas
        //StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }); //-> a\nc\nd
        //StripComments("\n#\nF\nE\n\nBD\nF\nBC\n\n#\n#\nGH\n", new string[] { "#", "$" });
        //StripComments(" ", new string[] { "#", "$" });
    }

    public static string StripComments(string text, string[] commentSymbols)
    {
        if (string.IsNullOrWhiteSpace(text))
            return string.Empty;

        var newString = string.Empty;
        string[] arrayTxt = text.Split("\n");

        foreach (var lineTxt in arrayTxt)
        {
            int auxPosition = positionComment(lineTxt, commentSymbols);
            newString += string.Concat(lineTxt.Substring(0, auxPosition).TrimEnd(), "\n");
        }

        newString = newString.Substring(0, newString.Length - 1);

        return newString;
    }

    public static int positionComment(string txt, string[] commentSymbols)
    {
        if (string.IsNullOrWhiteSpace(txt))
            return 0;

        int position = txt.Length;
        char[] auxTxt = txt.ToArray();

        foreach (var x in commentSymbols)
        {
            if (auxTxt[0].ToString() == x)
                return 0;

            int y = txt.IndexOf(x);

            if (position > y && y > 0)
                position = y;
        }

        return position;
    }
}