public class Kata
{
	//--> https://www.codewars.com/kata/530e15517bc88ac65600071

	public static void Main()
	{
		Rot13("10+2 is twelve"); //grfg
	}

	public static string Rot13(string message)
	{
		string alphabet = "0abcdefghijklmnopqrstuvwxyz";
		string root13 = "0nopqrstuvwxyzabcdefghijklm";
		char[] root13Array = root13.ToArray();

		var result = string.Empty;
		var crypt = string.Empty;

		foreach (var x in message)
		{
			bool IsUpper = char.IsUpper(x);
			string stringX = x.ToString().ToLower();

			if (char.IsLetter(x))
				crypt = root13Array[alphabet.IndexOf(stringX)].ToString();
			else
				crypt = stringX;

			if (IsUpper)
				crypt = crypt.ToUpper();

			result += crypt;
		}

		return result;
	}
}