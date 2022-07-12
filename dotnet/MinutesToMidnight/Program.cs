using System;

public class Minute
{
	//--> https://www.codewars.com/kata/58528e9e22555d8d33000163
	public static void Main()
	{
		var result = string.Empty;
		result = countMinutes(DateTime.Now.Date.AddHours(12)); //720 minutes
		result = countMinutes(DateTime.Now.Date.AddHours(23).AddMinutes(59)); //1 minute
	}

	public static string countMinutes(DateTime d)
	{
		var calcMinutes = DateTime.Now - d;
		return (calcMinutes.Minutes > 1) ? $"{calcMinutes.Minutes} minutes" : $"{calcMinutes.Minutes} minutes";
	}
}