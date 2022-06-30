public static class Kata
{
    //--> https://www.codewars.com/kata/590e03aef55cab099a0002e8/

    public static void Main()
    {
        //Incrementer(new int[] { 1, 2, 3 }); //2, 4, 6
        Incrementer(new int[] { 4, 6, 7, 1, 3 }); //5, 8, 0, 5, 8
    }

    public static int[] Incrementer(int[] numbers)
    {
        int[] newNumbers = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            newNumbers[i] = (numbers[i] + (i + 1)) % 10;
        }

        return newNumbers;
    }
}