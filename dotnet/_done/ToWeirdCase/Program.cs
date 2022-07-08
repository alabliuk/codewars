using System;

public class Kata
{
	//--> https://www.codewars.com/kata/52b757663a95b11b3d00062d
	public static void Main()
	{
		ToWeirdCase("This is a test"); //ThIs Is A TeSt
	}

	public static string ToWeirdCase(string s)
	{
		var newStr = s.ToLower().ToArray();
		var result = string.Empty;

		for (int i = 0, j = 0; i < s.Length; i++)
		{
			if (char.IsLetter(newStr[i]))
			{
				if (j % 2 == 1)
					result += newStr[i];
				else
					result += newStr[i].ToString().ToUpper();

				j++;
			}
			else
			{
				result += newStr[i];
			}

			if (char.IsWhiteSpace(newStr[i]))
				j = 0;
		}
		return result;
	}
}