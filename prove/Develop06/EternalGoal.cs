using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Eternal goal '{_shortName}' prorgress recorded. Points awarded: {_points}");
    }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}, {_description}, {_points},Eternal";
    }
}