using System;

class Program
{
    static void Main(string[] args)
    {
        
        PromtGenerator aPrompt = new PromtGenerator();
        int userChose = aPrompt.PromptUser();
        if (userChose == 1) 
        {
            Entry userWritten = new Entry();
            string userEntryContainer = userWritten.DisplayQuestion();
            Console.WriteLine();
            Console.WriteLine(userEntryContainer);
            Console.WriteLine("Would you like to save this entry? (y/n)");
            string saveOrNot = Console.ReadLine();
            if (saveOrNot == "y") 
            {
                
            }

        }
        

        
        
    }
}

