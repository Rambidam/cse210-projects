using System;
using System.IO;
using System.Collections.Generic;



public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }

    public string _entryText { get; set; }
    public void Display()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string randomPrompt = promptGenerator.GetRandomPrompt(promptGenerator._prompts);

        Entry newEntry = new Entry();

        Console.WriteLine(randomPrompt);
        newEntry._promptText = randomPrompt;
        Console.WriteLine("Enter your input here: ");
        newEntry._entryText = Console.ReadLine();
        newEntry._date = DateTime.Now.ToString();

        Journal journal = new Journal();
        journal._entries.Add(newEntry);
        journal.SaveToFile(journal._entries);


    }
}
    
          