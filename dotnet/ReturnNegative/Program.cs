public static class Kata
{
	//--> https://www.codewars.com/kata/55685cd7ad70877c23000102

	public static void Main()
	{
		MakeNegative(42);
	}

	public static int MakeNegative(int number)
	{
		if (number > 0)
			return number * -1;

		return number;
	}
}