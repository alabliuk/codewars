public class Kata
{
	//--> https://www.codewars.com/kata/5287e858c6b5a9678200083c

	public static void Main()
	{
		Narcissistic(1652);
	}

	public static bool Narcissistic(int value)
	{
		var charValue = value.ToString().ToArray();
		var calc = 0.0;

		foreach (char c in charValue)
		{
			calc += Math.Pow(char.GetNumericValue(c), charValue.Length);
		}

		if (calc != value)
			return false;

		return true;
	}
}