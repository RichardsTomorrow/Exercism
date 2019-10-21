using System;

public static class Grains
{
    public static ulong Square(int n) //=> (ulong)Math.Pow(2, n - 1);
    {
        if (n < 1 || n > 64) // this must be first otherwise the square will be calculated first
        {
            throw new ArgumentOutOfRangeException("The number must be between 1-64.");
        }

        ulong result = (ulong)Math.Pow(2, n - 1);  // 2^0 = 1 2^1 = 2 2^2 = 4
        return result;
    }
    public static ulong Total() 
    {       
        ulong total = 0;
        for (int i = 1; i <= 64; i++) // i must be 1 or it will be outside of range
        {
            total += Square(i);
        }
        return total;
    }
}