public class SnailSolution
{
    //--> https://www.codewars.com/kata/521c2db8ddc89b9b7a0000c1/
    public static void Main()
    {
        //int[][] array =
        //{
        //    new []{1, 2, 3},
        //    new []{4, 5, 6},
        //    new []{7, 8, 9}
        //};
        //Snail(array);

        int[][] array2 =
        {
            new []{1,  2,  3,  4},
            new []{5,  6,  7,  8},
            new []{9,  10, 11, 12},
            new []{13, 14, 15, 16},
        };
        Snail(array2);
    }

    public static int[] Snail(int[][] array)
    {
        var newArray = new int[array.Length * array.Length];
        int position = 0;

        for (int i = 0; i < array.Length; i++, position++)
        {
            newArray[position] = array[0][i];
        }

        for (int i = 1; i < array.Length; i++, position++)
        {
            newArray[position] = array[i][array.Length - 1];
        }

        for (int i = array.Length - 2; i >= 0; --i, position++)
        {
            newArray[position] = array[2][i];
        }

        for (int i = 0; i < array.Length - 1; i++, position++)
        {
            newArray[position] = array[1][i];
        }

        return newArray;
    }
}