using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int hamDist = 0;
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException("The DNA strands most both be of the same length");
        }
        return firstStrand.Zip(secondStrand, (a, b) => a == b ? 0 : 1).Sum(); // this is how I should do it using LINQ
        //for (int i = 0; i< firstStrand.Length; i++)
        //{
        //    if (firstStrand[i] != secondStrand[i])
        //    {
        //        hamDist++;
        //    }
        //}
        //return hamDist;
    }
}