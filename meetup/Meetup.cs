using System;
using System.Collections.Generic;
using System.Linq;
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
    private int m, y, teenthLowerBound = 13, teenthUpperBound = 19;
    public Meetup(int month, int year)
    {
        m = month;
        y = year;
    }
    public static IEnumerable<DateTime> AllDatesInMonth(int year, int month)
        {
            int days = DateTime.DaysInMonth(year, month);
            for (int day = 1; day <= days; day++)
            {
                yield return new DateTime(year, month, day);
            }
        }
    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        IEnumerable<DateTime> dt = AllDatesInMonth(y,m).Where(ch => ch.DayOfWeek == dayOfWeek);
        switch((int) schedule) {
            case (int) Schedule.First:
                return dt.First();
                break;
            case (int) Schedule.Last:
                return dt.Last();
                break;
            case (int) Schedule.Second : case (int) Schedule.Third : case (int) Schedule.Fourth:
                return dt.ElementAt((int)schedule - 1);
                break;
            case (int) Schedule.Teenth:
                return dt.Where(ch => ch.Day >= teenthLowerBound && ch.Day <= teenthUpperBound).First();
                break;
            default:
                throw new ArgumentException();
                break;
        }
    }
}