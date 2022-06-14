using System;
using System.Collections.Generic;

namespace Solution
{
    //--> https://www.codewars.com/kata/5583090cbe83f4fd8c000051/

    public class Digitizer
    {
        public static void Main()
        {
            Digitize(0);
        }

        public static long[] Digitize(long n)
        {
            char[] intArray = n.ToString().ToCharArray();
            Array.Reverse(intArray);
            var longArray = new long[intArray.Length];

            for(int i = 0; i < intArray.Length; i++)
            {
                longArray[i] = (long)char.GetNumericValue(intArray[i]);
            }

            return longArray;
        }
    }
}