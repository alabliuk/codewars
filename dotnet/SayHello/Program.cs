public class Kata
{
    //--> https://www.codewars.com/kata/5302d846be2a9189af0001e4/train/csharp

    public static void Main()
    {
        Console.WriteLine(SayHello(new string[] { "John", "Smith", "teste2" }, "Phoenix", "Arizona"));
        Console.WriteLine(SayHelloJoinString(new string[] { "John", "Smith", "teste2" }, "Phoenix", "Arizona"));
    }

    public static string SayHello(string[] name, string city, string state)
    {
        string auxName = string.Empty;
        foreach (string x in name)
        {
            auxName = auxName + " " + x;
        }
        return $"Hello,{auxName}! Welcome to {city}, {state}!";
    }

    public static string SayHelloJoinString(string[] name, string city, string state)
    {
        return $"Hello, {string.Join(" ", name)}! Welcome to {city}, {state}!";
    }
}