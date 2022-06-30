public class Kata
{
    //--> https://www.codewars.com/kata/58068479c27998b11900056e/

    public static void Main()
    {
        //SortTwisted37(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        SortTwisted37(new[] { 9, 2, 4, 7, 3 }); //2,7,4,3,9
    }

    public static int[] SortTwisted37(int[] array)
    {
        var newArray = array.OrderBy(x => x)
            .Where(x => x == 3)
            .ToArray();




        if (array.Length >= 7)
        {
            var aux = newArray[2];
            newArray[2] = newArray[6];
            newArray[6] = aux;
        }
        else
        {
            var aux = newArray[2];
            newArray[2] = newArray[array.Length - 1];
            newArray[array.Length - 1] = aux;
        }

        return newArray;
    }
}