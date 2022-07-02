public class Kata
{
    //--> https://www.codewars.com/kata/525f50e3b73515a6db000b83

    public static void Main()
    {
        var intNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        CreatePhoneNumber(intNumbers);
    }

    public static string CreatePhoneNumber(int[] numbers)
    {
        var strNumbers = string.Join(",", numbers).Replace(",", "");
        return string.Format("{0:(0##) ###-####}", Convert.ToInt64(strNumbers));
    }
}