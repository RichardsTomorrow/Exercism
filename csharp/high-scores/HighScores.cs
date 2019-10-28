using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> scoreList; //= new List<int>();

    public HighScores(List<int> list)
    {
        scoreList = list;
    }

    public List<int> Scores()
    {
        return scoreList;
    }

    public int Latest()
    {
        return scoreList.Last();
    }

    public int PersonalBest()
    {
        return scoreList.Max();
    }

    public List<int> PersonalTopThree()
    {
        return scoreList.OrderByDescending(x => x).Take(3).ToList(); // .ToList  is needed since it will cast the IEnumerable back to list.
    }
}