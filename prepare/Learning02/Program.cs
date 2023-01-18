using System;

class Program
{

    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Vodafone";
        job1._jobTitle = "Telecom Technician";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Nowo";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2021;
        job2._endYear = 2026;
        
        job1.Display();
        job2.Display();

        Resume resume1 = new Resume();

        resume1._name = "Eddie Bambo";
        resume1._job.Add(job1);
        resume1._job.Add(job2);
        resume1.DisplayResume();



        
    }
}