using System;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int score = 0;
        string toBeScored = input.ToLower();

        foreach(char letter in toBeScored)
        {
            if( letter == 'd' || letter == 'g')
            {
                score += 2;
            }
            else if(letter == 'b'|| letter == 'c'|| letter == 'm'|| letter == 'p')
            {
                score += 3;
            }
            else if (letter == 'f'|| letter == 'h' || letter == 'v'|| letter == 'w' || letter == 'y')
            {
                score += 4;
            }
            else if (letter == 'k')
            {
                score += 5;
            }
            else if (letter == 'j' || letter == 'x')
            {
                score += 8;
            }
            else if (letter == 'q' || letter == 'z')
            {
                score += 10;
            }
            else
            {
                score++;
            }
        }

        return score;
        
    }
}