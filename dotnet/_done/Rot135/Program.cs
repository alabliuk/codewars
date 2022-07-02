public class Kata
{
	public static void Main()
    {
		ROT135("The quick brown fox jumps over the 2 lazy dogs");
		ROT135("Gur dhvpx oebja sbk whzcf bire gur 7 ynml qbtf");
	}

    public static string ROT135(string message)
    {
		string alphabet = "abcdefghijklmnopqrstuvwxyz1234567890";
		string root13 = "nopqrstuvwxyzabcdefghijklm6789012345";
		char[] root13Array = root13.ToArray();

		var result = string.Empty;
		var crypt = string.Empty;

		foreach (var x in message)
		{
			bool IsUpper = char.IsUpper(x);
			string stringX = x.ToString().ToLower();

			if (char.IsLetter(x) || char.IsNumber(x))
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