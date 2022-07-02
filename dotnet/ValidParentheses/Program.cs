public class Parentheses
{
    //--> https://www.codewars.com/kata/52774a314c2333f0a7000688/

    public static void Main()
    {
        ValidParentheses(")x))hxae(u)dhbxag)ghsgy)(wgvt)hj(i)");
    }

    public static bool ValidParentheses(string input)
    {
        if (input.Length < 1 && input.Length <=100)
            return false;

        var a = input.Where(x => x == '(').Count();
        var b = input.Where(x => x == ')').Count();

        if (a == b)
            return true;

        return false;
    }
}