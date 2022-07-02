using System;
public static class Kata
{
	//--> https://www.codewars.com/kata/545cedaa9943f7fe7b000048

	public static void Main()
	{
		//IsPangram("The quick brown fox jumps over the lazy dog");
		IsPangram("aaaaaaaaaaaaaaaaaaaaaaaaaa");
	}

	public static bool IsPangram(string str)
	{
		string alphabet = "abcdefghijklmnopqrstuvwxyz";

		foreach (char x in alphabet)
		{
			var result = str.ToLower().IndexOf(x);

			if (result < 0)
				return false;
		}

		return true;
	}
}