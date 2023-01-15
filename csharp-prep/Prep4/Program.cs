using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int UserNumber = -1;    
        while(UserNumber ! = 0)
        {
            Console.Write("Please enter a number (0 to close the list): ");
            String userResponse = Console.ReadLine();
            UserNumber = int.Parse(userResponse);

            if (UserNumber != 0)
            {
                numbers.Add(UserNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"sum result: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");



        /////////////////////////////////////////
        int max = numberss[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}