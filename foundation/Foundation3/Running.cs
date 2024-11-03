using System;
using System.Collections.Generic;

public class Running : Activity
{
    private double distance; 

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }
}