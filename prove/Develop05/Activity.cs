using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected string _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
        Console.WriteLine();


        Console.WriteLine($"How long, in seconds, would you like for your sessions?" + _duration);


    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nThank you for participating in this activity. We hope it was helpful for you.");
        Console.WriteLine("Take a deep breath and reflect on what you've gained.");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {

            Console.Write("+");

            Thread.Sleep(500);
            
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character

            // Console.WriteLine("/");
            // Thread.Sleep(250);
            // Console.WriteLine("\b-");
            // Thread.Sleep(250);
            // Console.WriteLine("\b\\");
            // Thread.Sleep(250);
            // Console.WriteLine("\b|");
            // Thread.Sleep(250);
            // Console.WriteLine("\b");

        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}