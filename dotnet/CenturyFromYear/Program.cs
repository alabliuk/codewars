public static class Kata
{
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