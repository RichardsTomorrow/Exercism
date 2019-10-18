using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        return input.ToLower().Where(letter => Char.IsLetter(letter)).GroupBy(letter => letter).Count() == 26;
    }
}
