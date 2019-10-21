using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentException("The number entered must be greater than 0.");
        }
        int counter = 0;
        while(number != 1)
        {
            counter++;
            if (number % 2 == 0)
            {
                number = number / 2;
            }
            else
            {
                number = (number * 3) + 1; // I forgot to add the plus one. Don't forget to do that.
            }
        }
        return counter;
    }
}