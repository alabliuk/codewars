public static class Kata
{
    //--> https://www.codewars.com/kata/54e6533c92449cc251001667/
    public static void Main()
    {
        UniqueInOrder(string.Empty);
    }

    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        var iterableArray = iterable.ToList();
        var result = string.Empty;

        for (int i = 1; i < iterableArray.Count(); i++)
        {
            if (!iterableArray[i - 1].Equals(iterableArray[i]))
            {
                result += iterableArray[i - 1];
            }
        }

        if (iterable.Count() > 0)
            result += iterableArray[iterableArray.Count() - 1];

        return result.Cast<T>();
    }
}