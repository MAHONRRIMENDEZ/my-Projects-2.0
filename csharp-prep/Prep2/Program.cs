using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userAnswer = Console.ReadLine();
        int percent = int.Parse(userAnswer);
        
        string userGradeLetter = "";

        if (percent >= 90)
        {
            userGradeLetter = "A";
        } 
        else if (percent >= 80)
        {
            userGradeLetter = "B";
        }
        else if (percent >= 70)
        {
            userGradeLetter = "C";
        }
        else if (percent >= 60)
        {
            userGradeLetter = "D";
        }
        else
        {
            userGradeLetter = "F";
        }

        Console.WriteLine($"Your grade is: {userGradeLetter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congrats You've approved!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
