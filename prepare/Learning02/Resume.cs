using System;

public class Resume
{
    public string _name;

//I had a hard time to complete the Resume part of the learning Activitie 
//so I needed to review the solution sample to complete this part
    public List<job> _jobs = new List<job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");


        foreach (job job in _jobs)
        {

            job.Display();
        }
    }
}