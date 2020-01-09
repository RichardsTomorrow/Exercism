using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly Dictionary<int, List<string>> _roster = new Dictionary<int, List<string>>();
    public void Add(string student, int grade)
    {
        if (_roster.ContainsKey(grade))
        {
            _roster[grade] = new List<string>();
        }
        _roster[grade].Add(student);
    }

    public IEnumerable<string> Roster()
    {
        List<string> fullRoster = new List<string>();
        foreach(int grade in _roster.Keys)
        {
            fullRoster.AddRange(_roster[grade]);
        }
        return fullRoster;
    }

    public IEnumerable<string> Grade(int grade)
    {
        return _roster[grade];
    }
}