using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int x = int.Parse(gradePercentage);


        if (x >= 90)
        {
            Console.WriteLine("Your letter grade is A.");
        }
        else if (x >= 80 && x < 90)
        {
            Console.WriteLine("Your letter grade is B.");
        }
        else if (x >= 70 && x < 80)
        {
            Console.WriteLine("Your letter grade is C.");
        }
        else if (x >= 60 && x < 70)
        {
            Console.WriteLine("Your letter grade is D.");
        }
        else
        {
            Console.WriteLine("Your letter grade is F.");
        }

        if (x >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the course.");
        }
        else
        {
            Console.WriteLine("Don't let this stop you—it's just a step toward success. You'll get it next time!");
        }




    }
}