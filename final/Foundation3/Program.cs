using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture();
        string standardLecture = lecture.ShowStandardDetails();
        Console.WriteLine(standardLecture);
        string fullLecture = lecture.ShowFullDetails();
        Console.WriteLine(fullLecture);
        string shortLecture = lecture.ShowShortDescription();
        Console.WriteLine(shortLecture);
        
        Reception reception = new Reception();
        Outdoor outdoor = new Outdoor();
    }
}