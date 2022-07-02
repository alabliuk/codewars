public class Kata
{
	//--> https://www.codewars.com/kata/55f8a9c06c018a0d6e000132

	public static void Main()
	{
		Console.WriteLine(ValidatePin("1234")); //true
		Console.WriteLine(ValidatePin("09876\n")); //false
		Console.WriteLine(ValidatePin("+88888")); //false
		Console.WriteLine(ValidatePin("0000")); //true
	}

	public static bool ValidatePin(string pin)
	{
		if (pin.Length == 6 || pin.Length == 4)
		{
			var aux = pin.Replace(" ", "").Replace("\n", "").Replace("\t", "").Replace("+", "").Replace("-", "");
			if (aux.Length != 6 && aux.Length != 4)
				return false;

			var validation = int.TryParse(pin, out int valor);

			if (validation)
				return true;
			else
				return false;
		}
		else
		{
			return false;
		}
	}
}