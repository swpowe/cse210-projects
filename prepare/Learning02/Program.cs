using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        Job job1 = new Job();
        Job job2 = new Job();

        job1._companyName = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2021;
        
        job2._companyName = "Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2021;
        job2._endYear = 2024;

        myResume._name = "Spencer Powell";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}