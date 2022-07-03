﻿public class Kata
{
    public static void Main()
    {
        Uncensor("*h*s *s v*ry *tr*ng*", "Tiiesae"); //"This is very strange",
    }

    public static string Uncensor(string infected, string discovered)
    {
        var newStr = string.Empty;

        for (int i = 0, j=0; i < infected.Count(); i++)
        {
            if (infected[i] == '*')
            {
                newStr += discovered[j];
                j++;
            }
            else
                newStr += infected[i];
        }
        return newStr;
    }
}