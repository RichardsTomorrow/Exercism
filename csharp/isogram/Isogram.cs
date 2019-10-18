using System;
using System.Linq;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLower();
        char[] wordChar = word.ToCharArray().Where(Char.IsLetter);

        Array.Sort(wordChar);

        for (int i = 0; i < word.Length-1; i++)
        {
            if (wordChar[i] == wordChar[i + 1])
                return false;
        }
        return true;

    }
}
