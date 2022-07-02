public static class Kata
{
	//--> https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097
	public static void Main()
	{
		СenturyFromYear(1705);
		СenturyFromYear(2000);
		СenturyFromYear(2002);
	}

	public static int СenturyFromYear(int year)
	{
		var century = year / 100;

		if (year != (century * 100))
			century += 1;

		return century;
	}
}