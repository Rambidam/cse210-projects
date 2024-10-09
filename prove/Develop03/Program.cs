using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("W03 Prove: Developer—Scripture Memorizer");

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture("Trust in the Lord with all thine heart and lean not unto thine own understanding");

        while (true)
        {
            Console.Clear();
            Console.Write(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hiddern. Good job memorizing the scripture!");
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string _response = Console.ReadLine();

            if (_response.ToLower() == "quit")
            {
                Console.WriteLine("You have ended the program.");
                break;
            }
            scripture.HideRandomWords();
        }
    }
}

// For the stretch challenge:
// Matched the number of underscores to the number of letters in each hidden word
// Randomly selected from only those words that are not yet hidden