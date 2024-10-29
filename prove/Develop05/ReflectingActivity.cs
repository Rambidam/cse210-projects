using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };    
    
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base(
        "Reflecting Activity",
        "This activity will help you reflect on times in your life when you have shown your strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        ActivityLog.ReflectingActivityCount++;
        DisplayStartingMessage();

        Console.WriteLine("Enter the duration in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            ShowSpinner(3);

            string prompt = GetRandomPrompt();
            Console.WriteLine("Take a moment to reflect on this experience...");
            Console.WriteLine($"Prompt: {prompt}");
            ShowCountDown(3);

            int elapsed = 0;
            while (elapsed < duration)
            {
                string question = GetRandomQuestion();
                Console.WriteLine($"\nQustion: {question}");
                ShowSpinner(5);
                elapsed += 5;
            }

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

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(_prompts);
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(_questions);
    }
}