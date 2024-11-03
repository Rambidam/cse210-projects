using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int laps;
    private const double LapDistance = 0.05;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * LapDistance;
    }
}