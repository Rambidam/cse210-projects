using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");    

        // These statements are for Core Requirements 1 and 2, where the user needs to specify the magic number.
        // Console.WriteLine("What is the magic number?");
        // int magicNumber = int.Parse(Console.ReadLine());

        // This statement is for Core Requirement 3, where the magic number is generarated randomly.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guessedNumber = -1;

        while (guessedNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessedNumber = int.Parse(Console.ReadLine());
            
            if (magicNumber > guessedNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessedNumber)
            {
                Console.WriteLine("Lower");
            }
            else        
            {
                Console.WriteLine("You guessed it.");
            }
        }
    }
}

