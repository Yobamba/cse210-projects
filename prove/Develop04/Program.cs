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
            int userTiempo;
            userStartOption = int.Parse(Console.ReadLine());
            if (userStartOption == 1) {
                Breathing breath = new Breathing();
                breath.StartMessage();
                Thread.Sleep(2000);
                userTiempo = breath.PromptActivityTime();
                breath.ShowAnimation();
                breath.BreathInNOut(userTiempo);

                
            } 
            
            else if (userStartOption == 2) 
            {
                Reflecting reflection = new Reflecting();
                reflection.StartMessage();
                Thread.Sleep(2000);
                userTiempo = reflection.PromptActivityTime();
                reflection.ShowAnimation();
                reflection.Ponder();


            }
       
        
            
        }
        
        
        
    }
}