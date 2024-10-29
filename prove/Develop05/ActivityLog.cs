using System;

public class ActivityLog
{
    public static int BreathingActivityCount {get; set;} = 0;
    public static int ReflectingActivityCount {get; set;} = 0;
    public static int ListingActivityCount {get; set;} = 0; 


    public static void DisplayActivityCounts()
    {
        Console.WriteLine($"Breathing Activities performed: {BreathingActivityCount}");
        Console.WriteLine($"Reflecting Activities performed: {ReflectingActivityCount}");
        Console.WriteLine($"Listing Activities performed: {ListingActivityCount}");
    }
}