public class Kata
{
    //--> https://www.codewars.com/kata/577a98a6ae28071780000989
    public static void Main()
    {
        Min(new[] { -52, 56, 30, 29, -54, 0, -110 }); //-110
        Min(new[] { 42, 54, 65, 87, 0 }); //0
        Max(new[] { 4, 6, 2, 1, 9, 63, -134, 566 }); //566
        Max(new[] { 5 }); //5
    }

    public static int Min(int[] list)
    {
        return list.OrderBy(x => x).ToList().First();
    }

    public static int Max(int[] list)
    {
        return list.OrderByDescending(x => x).ToList().First();
    }
}