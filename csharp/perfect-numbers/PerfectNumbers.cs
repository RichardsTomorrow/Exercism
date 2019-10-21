using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException("The number entered must be greater than 0.");
        }
        int aliquotSum = 0;
        for (int x = 1; x < number; x++)
        {
            if (number % x == 0)
            {
                aliquotSum += x;
            }
        }

        if (aliquotSum == number)
        {
            return Classification.Perfect;
        }
        else if (aliquotSum > number)
        {
            return Classification.Abundant;
        }
        else
        {
            return Classification.Deficient;
        }
        // throw new NotImplementedException();
    }
}
