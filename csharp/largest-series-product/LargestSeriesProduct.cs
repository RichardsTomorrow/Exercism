using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if (span == 0) return 1; 
        if (span < 0) throw new ArgumentException("The span can't be negative");
        if (Regex.IsMatch(digits, @"[^0-9]")) throw new ArgumentException("The series of digits must contain numbers");
        if (span > digits.Length) throw new ArgumentException("The span must be smaller than the length of digits");


        long maxProduct = 0;
        for (int i = 0; i <= digits.Length-span; i++)
        {
            long tempProduct = 1;

            for (int j = 0; j < span ; j++)
            {
                tempProduct *= Int64.Parse(digits[i + j].ToString());

            }
                if (tempProduct > maxProduct) { maxProduct = tempProduct; }
        }
        return maxProduct;
    }
}