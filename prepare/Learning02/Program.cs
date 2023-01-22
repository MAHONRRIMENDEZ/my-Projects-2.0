using System;

class Program
{
    static void Main(string[] args)
    {
    job job1 = new job();
    job1._jobTitle = "Software Engineer";
    job1._company = "Microsoft";
    job1._startYear = 2019;
    job1._endYear = 2022;

    job job2 = new job();
    job2._jobTitle = "Manager";
    job2._company = "Apple";
    job2._startYear = 2022;
    job2._endYear = 2023;

    job job3 = new job();
    job3._jobTitle = "UnderWriter";
    job3._company = "HomeRiverGroup";
    job3._startYear = 2021;
    job3._endYear = 2023;


    Resume myResume = new Resume();
    myResume._name = "Mahonrri Mendez";

    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);
    myResume._jobs.Add(job3);
    myResume.Display();
    }
}