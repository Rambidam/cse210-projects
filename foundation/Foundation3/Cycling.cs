using System;
using System.Collections.Generic;

public class Cycling : Activity
{
    private double distance; 

    public Cycling(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }
}
