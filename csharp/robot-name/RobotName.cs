using System;
using System.Text;
using System.Collections.Generic;

public class Robot
{
    public static HashSet<string> usedNames = new HashSet<string>();

    public Robot()
    {
         this.Name = NameGenerator();
    }
    public string Name
    {
        get; private set;
    }

    private string NameGenerator()
    {
        StringBuilder sb = new StringBuilder();
        var random = new Random();

        sb.Append(Convert.ToChar(random.Next(65,91)));
        sb.Append(Convert.ToChar(random.Next(65, 91)));
        sb.Append(Convert.ToString(random.Next(100, 1000)));
        string newName = sb.ToString();
        if (usedNames.Contains(newName)) { newName = NameGenerator(); }
        usedNames.Add(newName);

        return newName;
    }

    public void Reset()
    {
        this.Name = NameGenerator();
    }
}