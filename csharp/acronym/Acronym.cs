using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase) => 
        string.Join("", Regex.Split(phrase, @"[^a-zA-Z']+").Select(x => x.First()))  // thanks to this link https://exercism.io/tracks/csharp/exercises/acronym/solutions/c089c4a24a6f4627b7bf1b56429e7be9
        .ToUpper();
    //{
    //    //char[] splitter = { ' ', '-' };
    //    //string[] seperatedWords = phrase.Split(splitter);
    //    //char[] abb = new char[seperatedWords.Length];
    //    //for (int i = 0; i < seperatedWords.Length; i++)
    //    //{
    //    //    abb[i] = seperatedWords[i][0];
    //    //}
    //    //string answer = abb.ToString();
    //    //return answer;
    //    //string answer = "";
    //    //string answer => .Join("", Regex.Split(phrase, @"[^a-zA-Z']+").Select(x => x.First()));

    //    //return answer;
    //    //throw new NotImplementedException("Please implement this function");
    //}
}