public class Kata
{
	//--> https://www.codewars.com/kata/53da6d8d112bd1a0dc00008b

	public static void Main()
	{
		var result = ReverseList(new List<int> { 4, 3, 2, 1 });
	}

	public static List<int> ReverseList(List<int> list)
	{
		return Enumerable.Reverse(list).ToList();
	}
}