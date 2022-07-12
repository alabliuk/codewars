public class Dinglemouse
{

	//--> https://www.codewars.com/kata/5a6663e9fd56cb5ab800008b
	public static void Main()
	{
		//humanYearsCatYearsDogYears(1); //1,15,15
		//humanYearsCatYearsDogYears(2); //2,24,24
		humanYearsCatYearsDogYears(10); //10,56,64
	}

	public static int[] humanYearsCatYearsDogYears(int humanYears)
	{
		//cat
		int catYears = 15;
		if (humanYears > 1)
		{
			catYears += 9;
			if (humanYears > 2)
				catYears += ((humanYears - 2) * 4);
		}

		//dog
		int dogYears = 15;
		if (humanYears > 1)
		{
			dogYears += 9;
			if (humanYears > 2)
				dogYears += ((humanYears - 2) * 5);
		}

		return new int[] { humanYears, catYears, dogYears };
	}
}