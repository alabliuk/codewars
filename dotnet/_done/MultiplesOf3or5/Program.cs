public static class Kata
{
	//--> https://www.codewars.com/kata/514b92a657cdc65150000006
	public static void Main()
	{
		Solution(10); //23
	}

	public static int Solution(int value)
	{
		int sum = 0;
		for (int i = 3; i < value; i++)
		{
			if (i % 5 == 0 || i % 3 == 0)
			{
				sum += i;
			}
		}
		return sum;
	}
}