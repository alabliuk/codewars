using System;

public static class Kata
{
	//--> https://www.codewars.com/kata/5266876b8f4bf2da9b000362

	public static void Main()
	{
		//var result = Likes(new string[0]);
		var result = Likes(new string[] { "Alex", "Jacob", "Mark", "Max", "Andre" });
	}

	public static string Likes(string[] name)
	{
		string result = "no one likes this";

		if (name.Length == 1)
			result = $"{name[0]} likes this";
		else if (name.Length == 2)
			result = $"{name[0]} and {name[1]} likes this";
		else if (name.Length == 3)
			result = $"{name[0]}, {name[1]} and {name[2]} likes this";
		else if (name.Length > 3)
			result = $"{name[0]}, {name[1]} and {name.Length - 2} others likes this";

		return result;
	}
}