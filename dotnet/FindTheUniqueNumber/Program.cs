public class Kata
{
    public static void Main()
    {
        GetUnique(new[] { 11, 11, 14, 11, 11 });
    }

    public static int GetUnique(IEnumerable<int> numbers)
    {
        var duplicates = numbers.GroupBy(x => x)
            .SelectMany(y => y.Skip(1))
            .Distinct()
            .ToList();

        var newNumbers = numbers.ToList();

        foreach (var z in duplicates)
        {
            newNumbers.RemoveAll(x => x == z);
        }

        return newNumbers.First();
    }
}