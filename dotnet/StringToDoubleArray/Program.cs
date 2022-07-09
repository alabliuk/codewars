public class stringArrayMethods
{
	//--> https://www.codewars.com/kata/5783d8f3202c0e486c001d23
	public static void Main()
	{
		ToDoubleArray(new string[] { "1.1", "2.2", "3.3" });
	}

	public static double[] ToDoubleArray(string[] stringArray)
	{
		double[] doubleArray = new double[stringArray.Count()];

		for (int i = 0; i < stringArray.Count(); i++)
		{
			doubleArray[i] = double.Parse(stringArray[i]);
		}

		return doubleArray;
	}
}