using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private int month;
    private int year;

    public Meetup(int month, int year)
    {
        this.month = month;
        this.year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        DateTime date;

        switch (schedule)
        {
            case Schedule.Teenth:
                date = new DateTime(year, month, 13);
                while (date.DayOfWeek != dayOfWeek)
                    date = date.AddDays(1);
                return date;
            case Schedule.First:
                date = new DateTime(year, month, 1);
                while (date.DayOfWeek != dayOfWeek)
                    date = date.AddDays(1);
                return date;
            case Schedule.Second:
                date = new DateTime(year, month, 8);
                while (date.DayOfWeek != dayOfWeek)
                    date = date.AddDays(1);
                return date;
            case Schedule.Third:
                date = new DateTime(year, month, 15);
                while (date.DayOfWeek != dayOfWeek)
                    date = date.AddDays(1);
                return date;
            case Schedule.Fourth:
                date = new DateTime(year, month, 22);
                while (date.DayOfWeek != dayOfWeek)
                    date = date.AddDays(1);
                return date;
            case Schedule.Last:
                date = new DateTime(year, month, DateTime.DaysInMonth(year,month));
                while (date.DayOfWeek != dayOfWeek)
                    date = date.AddDays(-1);
                return date;
            default:
                throw new ArgumentException("Enum mess up");
        }
    }
}