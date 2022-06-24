public class Kata
{
	//--> https://www.codewars.com/kata/546f922b54af40e1e90001da

	public static void Main()
	{
		var result = AlphabetPosition("The sunset sets at twelve o' clock.");
	}

	public static string AlphabetPosition(string text)
	{
		string alphabet = "0abcdefghijklmnopqrstuvwxyz";
		var result = string.Empty;
		foreach (char x in text.ToLower())
		{
			int position = alphabet.IndexOf(x);
			if (position > 0)
				result += string.Concat(position, " ");
		}

		return result.TrimEnd();
	}
}