public class Kata
{
	//--> https://www.codewars.com/kata/580a4734d6df748060000045
	public static void Main()
	{
		IsSortedAndHow(new[] { 1, 2 }); //"yes, ascending"
		IsSortedAndHow(new[] { 15, 7, 3, -8 }); //"yes, descending"
		IsSortedAndHow(new[] { 4, 2, 30 }); //"no"
	}

	public static string IsSortedAndHow(int[] array)
	{
		if (array[0] < array[1])
		{
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i - 1] > array[i])
					return "no";
			}
			return "yes, ascending";
		}
		else if (array[0] > array[1])
		{
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i - 1] < array[i])
					return "no";
			}
			return "yes, descending";
		}
		else
			return "no";
	}
}