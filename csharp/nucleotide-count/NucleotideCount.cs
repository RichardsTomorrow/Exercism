using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> nucleoCount = new Dictionary<char, int>();
        nucleoCount['A'] = 0;
        nucleoCount['T'] = 0;
        nucleoCount['G'] = 0;
        nucleoCount['C'] = 0;

        //for (int i = 0; i < sequence.Length; i++)
        foreach (char nbase in sequence)
        {
            if (nucleoCount.ContainsKey(nbase))
            {
                nucleoCount[nbase]++;
            }
            else
            {
                throw new ArgumentException("There was something wrong with your nucleotide sequence");
            }
        }

        return nucleoCount;
    }
}