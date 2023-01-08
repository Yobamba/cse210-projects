using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage? ");
        string userGrade = Console.ReadLine();
        int intVersion = int.Parse(userGrade);
        if (intVersion >= 90)
         {
            Console.Write("Your grade is A. ");
            Console.Write("Congratulations!! You passed the class. ");
        }

        else if (intVersion >= 80)
        {
            Console.Write("Your grade is B. ");
            Console.Write("Congratulations!! You passed the class. ");
        }
        else if (intVersion >= 70)
        {
            Console.Write("Your grade is C. ");
            Console.Write("Congratulations!! You passed the class. ");
        }
        else if (intVersion >= 60)
        {
            Console.Write("Your grade is D. ");
            Console.Write("Unfortunately, your grade is not enough to pass the class. Keep trying. ");
        }
        else if (intVersion >= 50)
        {
            Console.Write("Your grade is E. ");
            Console.Write("Unfortunately, your grade is not enough to pass the class. Keep trying. ");
        }
        else if (intVersion >= 40)
        {
            Console.Write("Your grade is F. ");
            Console.Write("Unfortunately, your grade is not enough to pass the class. Keep trying. ");
        }
    }
}