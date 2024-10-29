using System;
using System.Threading;

public class BreathingActivity: Activity
{
    public BreathingActivity(): base(
        "Breathing Activity",
        "This activity will help you relax by guiding you to breathe in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        ActivityLog.BreathingActivityCount++;
        DisplayStartingMessage();
        

        Console.Write("Enter the duration in seconds: ");

        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            ShowSpinner(3);

            int elapsed = 0;
            
            while (elapsed < duration)
            {
                Console.WriteLine("Breathe in...");
                ShowCountDown(3);
                Console.WriteLine("Breathe out...");
                ShowCountDown(5);
                elapsed += 6;
            }

            DisplayEndingMessage();
            ActivityLog.DisplayActivityCounts();

        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid duration.");
        }
    }
}