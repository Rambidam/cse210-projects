using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime date;
    private int duration;

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public DateTime Date => date;
    public int Duration => duration;

    public abstract double GetDistance();
    public double GetSpeed() 
    {
        return (GetDistance() / Duration) * 60; 
    }

    public double GetPace() 
    {
        return Duration / GetDistance(); 
    }

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} {this.GetType().Name} ({duration} min): " +
               $"Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
