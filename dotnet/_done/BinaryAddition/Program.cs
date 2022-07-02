public static class Kata
{
	//--> https://www.codewars.com/kata/551f37452ff852b7bd000139

	public static void Main()
	{
		var result = AddBinary(1, 2);
	}

	public static string AddBinary(int a, int b)
	{
		return Convert.ToString((a + b), 2);
	}
}