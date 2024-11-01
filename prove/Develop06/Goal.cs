using System;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine($"Goal '{_shortName}' marked complete.");
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} - Points: {_points}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}, {_description}, {_points}";
    }
}