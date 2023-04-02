using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture();
        lecture.ShowStandardDetails();
        lecture.ShowFullDetails();
        lecture.ShowShortDescription();
        Reception reception = new Reception();
        Outdoor outdoor = new Outdoor();
    }
}