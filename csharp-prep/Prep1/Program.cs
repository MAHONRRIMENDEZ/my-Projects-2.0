using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string Firstname = Console.ReadLine();
        Console.Write("What is your last name my friend? ");
        string Lastname =Console.ReadLine();

        Console.WriteLine($"you are {Lastname}, {Firstname} {Lastname} ");
    }
}