public class LineNumbering
{
    //--> https://www.codewars.com/kata/54bf85e3d5b56c7a05000cf9

    public static void Main()
    {
        Number(new List<string> { "a", "b", "c" });
    }

    public static List<string> Number(List<string> lines)
    {
        for (int i = 0; i < lines.Count; i++)
        {
            lines[i] = $"{i + 1}: {lines[i]}";
        }

        return lines;
    }
}