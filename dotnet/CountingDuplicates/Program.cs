public class Kata
{
    //--> https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1

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