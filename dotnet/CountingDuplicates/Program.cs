public class Kata
{
    public static void Main()
    {
        DuplicateCount("aabBcde");
    }

    public static int DuplicateCount(string str)
    {
        var duplicates = str.ToLower().GroupBy(x => x)
            .SelectMany(y => y.Skip(1))
            .Distinct()
            .ToList();

        return duplicates.Count();
    }
}