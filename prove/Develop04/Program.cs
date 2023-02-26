using System;

class Program
{
    static void Main(string[] args)
    {
        int userStartOption = 0;
        while (userStartOption != 4) 
        {
            Activity actObj = new Activity();
            actObj.DisplayActivities();
            Console.Write("Select a choice from the menu: ");
            Console.WriteLine();
            userStartOption = int.Parse(Console.ReadLine());
            if (userStartOption == 1) {
                Breathing breath = new Breathing();
                breath.StartMessage();
                breath.ShowAnimation();
                int userTiempo = breath.PromptActivityTime();
                breath.BreathInNOut(userTiempo);

                
            }
       
        
            
        }
        
        
        
    }
}