using System;
public class Kata
{
    //-> https://www.codewars.com/kata/5659c6d896bc135c4c00021e/train/csharp

    public static void Main()
    {
        //NextSmaller(21); //12
        //NextSmaller(531); //513
        //NextSmaller(2071); //2017
        //NextSmaller(123456798); //123456789

        NextSmaller(907); //790
    }

    public static long NextSmaller(long n)
    {
        char[] charN = n.ToString().ToArray();
        char[] result = charN;
        long finalResult = n;

        for (int i = 1; i <= charN.Length; i++)
        {
            var aux = result[charN.Length - i];
            result[charN.Length - i] = result[charN.Length - 1];
            result[charN.Length - 1] = aux;

            string strResult = new string(result);
            long tempResult = Convert.ToInt64(strResult);

            if (finalResult > tempResult)
                return tempResult;
        }

        if (finalResult >= n)
            return -1;

        return finalResult;
    }
}

//var aux = result[charN.Length - i];
//result[charN.Length - i] = result[charN.Length - 1];
//result[charN.Length - 1] = aux;