public static class Kata
{
	//--> https://www.codewars.com/kata/5262119038c0985a5b00029f
	public static void Main()
	{
		var result = IsPrime(3);
	}

	public static bool IsPrime(int n)
	{
		if (n <= 1)
			return false;

		for (int i = n-1; i >= 2; i--)
		{
			if (n % i == 0)
				return false;
		}

		return true;
	}
}