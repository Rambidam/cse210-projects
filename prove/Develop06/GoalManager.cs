using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int answer;


    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void Start()
    {
         int answer;

        do 
        {
            Console.WriteLine("You have 0 points.");

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string x = Console.ReadLine();

            if (int.TryParse(x, out answer))
            {
                switch (answer)
                {
                    case 1:
                        var goalManager = new GoalManager();
                        goalManager.Start();
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
        }   while (answer != 6); 

        
        }   
    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal ");
        Console.WriteLine("2. Eternal Goal ");
        Console.WriteLine("3. Checklist Goal ");
        Console.WriteLine("Which type of goal would you like to create? ");
        string x = Console.ReadLine();
        int answer;

            if (int.TryParse(x, out answer))
            {
                switch (answer)
                {
                    case 1:
                        var simpleGoal = new SimpleGoal();
                        simpleGoal.RecordEvent();
                        break;
                    case 2: 
                        var eternalGoal = new EternalGoal();
                        eternalGoal.RecordEvent();
                        break;
                    case 3:
                        var checklistGoal = new ChecklistGoal();
                        checklistGoal.RecordEvent();
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
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals(List<Goal> _goals)
    {
        {
        Console.WriteLine("What is the filename? ");
        string file = Console.ReadLine();

        if (file == "file.csv")
        {
            Console.WriteLine("Saving to file...");

            string filename = "file.csv";

            using (StreamWriter outputFile = new StreamWriter (filename, append: true))
            {
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine($"{goal._promptText},{goal._entryText},{goal._date}");
                }

            }

            Console.WriteLine("Entries saved to file successfully.");
        }
        else 
            {
                Console.WriteLine("No such filename is found.");
            }
    }
    }

    public void LoadGoals(List<Goal> _goals)
    {
            {
        Console.WriteLine("What is the filename?");
        string file = Console.ReadLine();

        if (file == "file.csv")
        {
            Console.WriteLine("Reading list from file...");

            string filename = "file.csv";
            string [] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                Goal newEntry = new Goal();
                newEntry._promptText = parts[0];
                newEntry._entryText = parts[1];
                newEntry._date = parts[2];

                _entries.Add(newEntry);
            }
        }
        else 
        {
            Console.WriteLine("No such filename is found.");
        }
    }   
    }
}    

