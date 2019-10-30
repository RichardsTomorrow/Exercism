using System;
using System.Linq;
using System.Collections.Generic;
/// <summary>
/// This article helped a lot http://www.cs.trincoll.edu/~ram/cpsc110/inclass/conversions.html
/// </summary>

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if (inputBase < 2 || outputBase < 2) throw new ArgumentException("The base must be larger than 1");
        if (inputDigits.Any(d => d < 0 || d >= inputBase)) throw new ArgumentException("Invalid digit in input digits");

        int s = 0;
        List<int> answer = new List<int>();

        int numberOfDigitsTo10 = inputDigits.Length - 1;
        for (int i = 0; i < inputDigits.Length; i++)
        {
            s += inputDigits[i] * (int)Math.Pow(inputBase, numberOfDigitsTo10--);
        }
        while (s > 0)
        {
            answer.Add(s % outputBase);
            s /= outputBase;
        }

        answer.Reverse();
        if (inputDigits.Sum() == 0) answer.Add(0);
        return answer.ToArray();
    }
}
