public class L33TGreekCase
{
	//--> https://www.codewars.com/kata/556025c8710009fc2d000011
	public static void Main()
	{
		GreekL33t("codewars"); //cθδεωαπs
		GreekL33t("kata"); //κατα
		GreekL33t("kumite"); //κμmιτε
		GreekL33t("greekleet"); //gπεεκlεετ
	}

	public static string GreekL33t(string str)
	{
		string alphabet =	"abcdefghijklmnopqrstuvwxyz";
		string greek =		"αβcδεfghιjκlmηθρqπsτμυωχγz";
		char[] greekArray = greek.ToArray();

		var result = string.Empty;
		var crypt = string.Empty;

		foreach (var x in str)
		{
			string stringX = x.ToString().ToLower();

			if (char.IsLetter(x))
				crypt = greekArray[alphabet.IndexOf(stringX)].ToString();
			else
				crypt = stringX;

			result += crypt;
		}

		return result;
	}
}