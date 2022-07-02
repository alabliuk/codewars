public class Kata
{
    public static void Main()
    {
        Solution("samurai", "ai"); //true 
        Solution("!@#$%^&*() :-)", ":-)"); //true
        Solution("abc\n", "abc"); //false
    }

    public static bool Solution(string str, string ending)
    {
        return str.EndsWith(ending);
    }
}