using System;

class Program
{
    static void Main(string[] args)
    {
                Console.WriteLine("Please select one of the following");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quite");
        Console.Write("what would you like to do?");
        string userResponse = Console.ReadLine();

        while (userResponse != "5")
        {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quite");
            if (userResponse == "1")
            {
                string userthoughs = Console.ReadLine(); 
            }

            else if (userResponse == "2")
            {
                Console.WriteLine("complete journal"); 
            }

            else if (userResponse == "3")
            {
                Console.WriteLine("what is your file name?");
                string userthoughs = Console.ReadLine(); 
            }

            else if (userResponse == "4")
            {
                Console.WriteLine("to save please provide a new file name");
                string userthoughs = Console.ReadLine(); 
            }

            else if (userResponse == "5")
            {
            }
            else (userResponse != "1", "2", "3", "4", "5")
            {
                break; 
            }
        }

    }
}