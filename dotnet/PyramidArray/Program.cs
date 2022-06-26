public class Kata
{
    //-> https://www.codewars.com/kata/515f51d438015969f7000013

    public static void Main()
    {
        Pyramid(3);
    }

    public static int[][] Pyramid(int n)
    {
        int[][] masterArray = new int[n][];

        for (int i = 1; i <= n; i++)
        {
            int[] lineArray = new int[i];
            for (int j = 0; j < i; j++)
            {
                lineArray[j] = 1;
            }
            masterArray[i - 1] = lineArray;
        }

        return masterArray;
    }
}