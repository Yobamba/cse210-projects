using System;

class Program
{
    static void Main(string[] args)
    {   string letter = "";
        Console.Write("What was your grade percentage? ");
        string userGrade = Console.ReadLine();
        int intVersion = int.Parse(userGrade);
        if (intVersion >= 90)
         {  
            letter = "A";
        }

        else if (intVersion >= 80)
        {
            letter = "B";
        }
        else if (intVersion >= 70)
        {
            letter = "C";
        }
        else if (intVersion >= 60)
        {
            letter = "D";
        }
        else if (intVersion >= 50)
        {
            letter = "E";
        }
        else if (intVersion >= 40)
        {
            letter = "F";
        }

        Console.Write($"Your grade is {letter}. ");
        if (intVersion >= 70)
        {
            Console.Write("Congratulations!! You passed the class. ");
        }
        else if (intVersion < 70)
        {
            Console.Write("Unfortunately, your grade is not yet high enough to pass the class. ");
        }
    }
}