using System;
using System.Collections.Generic;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        List<long> primeFactors = new List<long>();
        for (int i = 2; i <= number; i++)
        {
            while( number % i == 0)
            {
                primeFactors.Add(i);
                number /= i;
            }
        }
        return primeFactors.ToArray();
    }
}