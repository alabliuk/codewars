namespace Kata
{
	public static class Problem
	{
		//--> https://www.codewars.com/kata/587731fda577b3d1b0001196
		public static void Main()
		{
			//CamelCase("test case"); //TestCase
			//CamelCase("camel case method"); //CamelCaseMethod
			//CamelCase("say hello"); //SayHello
			CamelCase(" camel case word"); //CamelCaseWord
			CamelCase(""); //""
		}

		public static string CamelCase(string str)
		{
			var words = str.TrimStart().Split(' ');
			var newStr = string.Empty;
			int i = 0;

			foreach (var word in words)
			{
				if (!string.IsNullOrEmpty(words[i]))
					newStr += word[0].ToString().ToUpper() + word.Substring(1).ToLower();

				i++;
			}

			return newStr;
		}
	}
}