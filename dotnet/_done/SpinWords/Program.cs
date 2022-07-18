public class Kata
{
	//--> https://www.codewars.com/kata/5264d2b162488dc400000001
	public static void Main()
	{
		SpinWords("This is a test"); //This is a test
		SpinWords("This is another test"); //This is rehtona test
		SpinWords("You are almost to the last test"); //You are tsomla to the last test
	}

	public static string SpinWords(string sentence)
	{
		var strArray = sentence.Split(" ");
		var newSentence = string.Empty;

		foreach (var str in strArray)
		{
			if (str.Length >= 5)
			{
				var reverseStr = str.Reverse().ToArray();
				newSentence += string.Join("", reverseStr) + " ";
			}
			else
				newSentence += str + " ";
		}

		return newSentence.TrimEnd();
	}
}