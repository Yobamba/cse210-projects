using System;

class Program
{
    static void Main(string[] args)
    {
        
        Boolean stop = false;
        while (stop == false) 
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
                Journall journal = new Journall();
                // journal._entry = userEntryContainer;
                journal.SaveToFile(userEntryContainer);
                
            }

        }

        else if(userChose == 2) 
        {
            Journall journal = new Journall();
            journal.DisplayEntries();
        }

        else if(userChose == 3) 
        {
            Journall journal = new Journall();
            journal.DisplayEntries();
        }

        else if(userChose == 4) 
        {
            Console.WriteLine("There is no entry to save");
        }


        else if(userChose == 5) 
        {
            
            Console.WriteLine("Goodbye");
            stop = true;
        }
        }

        
        
    }
}

