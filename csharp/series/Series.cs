using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength < 1) throw new ArgumentException("Your slice length must be 1 or greater.");
        if (sliceLength > numbers.Length) throw new ArgumentException("Your slice length must be smaller than the length of the string.");
        if (Regex.IsMatch(numbers, @"[^\d]")) throw new ArgumentException("Your string must contain only digits");

        List<string> answers = new List<string>();
        
        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            string sub = numbers.Substring(i, sliceLength);
            answers.Add(sub);
        }
        return answers.ToArray();

    }
}