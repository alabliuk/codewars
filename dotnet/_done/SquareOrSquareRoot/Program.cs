using System;

public class Kata
{
    // --> https://www.codewars.com/kata/57f6ad55cca6e045d2000627

    public static void Main()
    {
        var input = new int[] { 4, 3, 9, 7, 2, 1 };
        SquareOrSquareRoot(input);
    }

    public static int[] SquareOrSquareRoot(int[] array)
    {
        var newArray = new int[array.Length];
        int result;

        for (int i = 0; i < array.Length; i++)
        {
            bool validation = Int32.TryParse(Math.Sqrt(array[i]).ToString(), out result);

            if (validation)
            {
                newArray[i] = result;
            }
            else
            {
                newArray[i] = (int)Math.Pow(array[i], 2);
            }
            Console.WriteLine(newArray[i]);
        }
        return newArray;
    }
}