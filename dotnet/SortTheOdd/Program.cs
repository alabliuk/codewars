public class Kata
{
    //--> https://www.codewars.com/kata/578aa45ee9fd15ff4600090d/

    public static void Main()
    {
        SortArray(new int[] { 5, 3, 2, 8, 1, 4 }); // 1, 3, 2, 8, 5, 4
    }

    public static int[] SortArray(int[] array)
    {
        int[] newArray = array;
        var x = array.OrderBy(x => x).Where(x => x % 2 == 1).ToList();
        int aux = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (newArray[i] % 2 == 1)
            {
                newArray[i] = x[aux];
                aux++;
            }                
        }

        return array;
    }
}