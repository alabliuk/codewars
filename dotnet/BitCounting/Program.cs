public class Kata
{
    //--> https://www.codewars.com/kata/526571aae218b8ee490006f4

    public static void Main()
    {
        var result = CountBits(4);
	}

    public static int CountBits(int n)
    {
        var binary = Convert.ToString(n, 2);
        return binary.Where(x => (x == '1')).Count();
    }
}