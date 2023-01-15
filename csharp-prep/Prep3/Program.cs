using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What will be yout magic number? ");
        //int UserNumber = Console.ReadLine();
        //int magicNumber = int.Parse(UserNumber);
    

    Random randomNumber = new Random ();
    int magicNumber = randomNumber.Next(1, 101);

    int Userguess = -1;
    while (Userguess != magicNumber)
    {
        Console.Write("What do you think is the number? ");
        Userguess = int.Parse(Console.ReadLine());

        if (magicNumber > Userguess)
        {
            Console.WriteLine("the number is Higher");
        }
        else if (magicNumber < Userguess);
        {
            Console.Write("the number is lower");
        }

        else
        {
            Console.WriteLine("you got it!");
        }
    }
    }

}