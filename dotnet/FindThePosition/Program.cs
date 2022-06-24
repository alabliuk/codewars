public class Kata
{
	//--> https://www.codewars.com/kata/5808e2006b65bff35500008f

	public static string PHRASE = "abcdefghijklmnopqrstuvwxyz";

	public static void Main()
	{
		var result = Position(Convert.ToChar("a"));
	}

	public static string Position(char alphabet)
	{
		char[] positions = PHRASE.ToCharArray();

		int i = 1;

		foreach (char x in positions)
		{
			if (x == alphabet)
			{
				return ($"Position of alphabet: {i}");
			}
			i++;
		}

		return "Not Found!";
	}
}