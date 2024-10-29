using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    
    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        ActivityLog.ListingActivityCount++;
        DisplayStartingMessage();

        Console.Write("Enter the duration in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            ShowSpinner(3);

            string prompt = GetRandomPrompt();
            Console.WriteLine($"Prompt: {prompt}");

            Console.WriteLine("Prepare to start listing...");
            ShowCountDown(5);

            List<string> userEntries = GetListFromUser(duration);

            Console.WriteLine($"You listed {userEntries.Count} items.");

            DisplayEndingMessage();
            ActivityLog.DisplayActivityCounts();

        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid duration.");
        }
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser(int duration)
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        Console.WriteLine("Start listing items (press Enter after each item):");
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }
        return items;
    }
}