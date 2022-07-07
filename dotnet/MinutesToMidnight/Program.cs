using System;

public class Minute
{
	//--> https://www.codewars.com/kata/58528e9e22555d8d33000163
	public static void Main()
	{
		countMinutes(DateTime.Now.Date.AddHours(12)); //720 minutes
		countMinutes(DateTime.Now.Date.AddHours(23).AddMinutes(59)); //1 minute
	}

	public static string countMinutes(DateTime d)
	{

		return "a";
	}
}