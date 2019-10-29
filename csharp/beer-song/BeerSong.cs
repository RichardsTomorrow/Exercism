using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder sb = new StringBuilder();
        //string song = null;
        for (int i = 0; i < takeDown; i++)
        {
            if (startBottles > 2)
            {
                sb.Append($"{startBottles} bottles of beer on the wall, {startBottles} bottles of beer.\n" +
                            $"Take one down and pass it around, {startBottles - 1} bottles of beer on the wall.");
            }
            else if (startBottles == 2)
            {
                sb.Append($"{startBottles} bottles of beer on the wall, {startBottles} bottles of beer.\n" +
                            $"Take one down and pass it around, 1 bottle of beer on the wall.");
            }
            else if (startBottles == 1)
            {
                sb.Append("1 bottle of beer on the wall, 1 bottle of beer.\n" +
                            "Take it down and pass it around, no more bottles of beer on the wall.");
            }
            else if (startBottles == 0)
            {
                sb.Append("No more bottles of beer on the wall, no more bottles of beer.\n" +
                            "Go to the store and buy some more, 99 bottles of beer on the wall.");
            }
            if(i + 1 < takeDown) { sb.Append("\n\n"); }
            startBottles--;
        }
        return sb.ToString();
    }
}