using System;

public class Kata
{
	//--> https://www.codewars.com/kata/517abf86da9663f1d2000003
	public static void Main()
	{
		ToCamelCase("the_stealth_warrior");
		ToCamelCase("The-Stealth-Warrior");
	}

	public static string ToCamelCase(string str)
	{
		var newStr = str.Split(new[] { '_', '-' });
		var result = string.Empty;

		for (int i = 0; i < newStr.Length; i++)
		{
			if (i > 0)
				result += char.ToUpper(newStr[i][0]) + newStr[i].Substring(1);
			else
				result += newStr[i];
		}

		return result;
	}
}