public static class Kata
{
    //--> https://www.codewars.com/kata/5977618080ef220766000022

    public static void Main()
    {
        Console.WriteLine(Usdcny(15));
        Console.WriteLine(Usdcny(465));
    }

    public static string Usdcny(int usd)
    {
        float calc = usd * 675;
        return string.Format("{0:#.00}", calc / 100) + " Chinese Yuan";
    }
}