using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength < 1) throw new ArgumentException("Your slice length must be 1 or greater.");
        if (sliceLength > numbers.Length) throw new ArgumentException("Your slice length must be smaller than the length of the string.");
        if () //put in a regx for anything but numbers
    }
}