using System;
using System.Collections.Generic;


public class Journal   

{
    public List<Entry> _entries = new List<Entry>();
    public int answer;
    public Entry entry = new Entry();


    public void AddEntry() 
    {
        do 
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
            Console.Write("What would you like to do? ");
            string x = Console.ReadLine();

            if (int.TryParse(x, out answer))
            {
                switch (answer)
                {
                    case 1:
                        entry.Display();
                        break;
                    case 2: 
                        DisplayAll();
                        break;
                    case 3:
                        Console.WriteLine("Load functionality not implemented yet.");
                        break;
                    case 4:
                        SaveToFile(_entries);
                        break;
                    case 5: 
                        Console.WriteLine("Load functionality not implemented yet.");
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
        }   while (answer != 5); 
    }

    public void DisplayAll()
    {

        {
            //string[] parts = line.Split(",");

            //string promptText = parts[0];
            // string entryText = parts[1];

        }
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display");
        }
        else
        {
            Console.WriteLine("Journal entries: ");
            foreach (Entry entry in _entries)
            {
                Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
                Console.WriteLine($"{entry._entryText}");
            }




        }
    }
     public void SaveToFile(List<Entry> _entries) 
    {
        Console.WriteLine("Saving to file...");


        using (StreamWriter outputFile = new StreamWriter ("file.csv"))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine("This will be the first line in the file.");
            }

        }

        //string[] lines = System.IO.File.ReadAllLines(filename);


    }
        
}  

   
    

    // public void LoadFromFile(string file) { }
