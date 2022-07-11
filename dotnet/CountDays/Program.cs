public class Day
{
	//--> https://www.codewars.com/kata/5837fd7d44ff282acd000157
	public static void Main()
	{
		var result = string.Empty;
		result = countDays(new DateTime(2016, 12, 2)); //"The day is in the past!"
		result = countDays(DateTime.Now); //"Today is the day!"\
		result = countDays(new DateTime(2022, 07, 15)); //
	}

	public static string countDays(DateTime d)
	{
		if (d.Date == DateTime.Now.Date)
			return "Today is the day!";
		else
		{
			var count = d - DateTime.Now;
			if (count.Days < 0)
				return "The day is in the past!";
			else
			{
				return $"{count.Days} days";
			}
		}
	}
}