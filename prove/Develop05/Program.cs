using System;

class Program
{
    static void Main(string[] args)
    {
        int answer;

        do 
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string x = Console.ReadLine();

            if (int.TryParse(x, out answer))
            {
                switch (answer)
                {
                    case 1:
                        var breathingActivity = new BreathingActivity();
                        breathingActivity.Run();
                        break;
                    case 2: 
                        var ReflectingActivity = new ReflectingActivity();
                        ReflectingActivity.Run();
                        break;
                    case 3:
                        var ListingActivity = new ListingActivity();
                        ListingActivity.Run();
                        break;
                    case 4: 
                        Console.WriteLine("Exiting the program.");
                        break;
                    default: 
                        Console.WriteLine("Invalid choice. Please enter a valid input.");
                        break;
                }
            }
                else 
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
        }   while (answer != 4); 
    }

    }

    // Showing Creativity and Exceeding Requirements
    // Keeping a log of how many times activities were performed.
    // New class (ActivityLog.cs)
