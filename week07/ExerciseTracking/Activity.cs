//Activity.cs
using System;

public abstract class Activity
{
    // Shared attributes
    private DateTime _date;
    private int _duration; 

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    // Getters for the properties
    public DateTime Date => _date;
    public int Duration => _duration;

    // Abstract methods 
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Summary method
    public string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({Duration} min): " +
               $"Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}