public class Breathing : Activity
{   
    private string[] _breathingInstructions = {"Breathe in...", "Breathe out..."};

    public Breathing() 
    {
        _activitySpecifications = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. ";
        _activityName = "Breathing activity";
    }

    
    
    // public void ShowBreathingWelcome() {
    //     Console.WriteLine("Welcome to this breathing activity. ");
    //     Console.WriteLine();
    //     Console.WriteLine(_activitySpecifications);
    //     Console.WriteLine();
    //     Console.WriteLine("Clear your mind and focus on your breathing. ");
    //     Console.WriteLine();
    //     // Console.WriteLine();
    // }

    public void BreathInNOut(int activityTime) 
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(activityTime);
    
        while (DateTime.Now < endTime) 
        {
            Console.WriteLine();
            Console.Write(_breathingInstructions[0]);
            for (int i = 5; i > 0; i--) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
           
            Console.Write(_breathingInstructions[1]);
            for (int i = 5; i > 0; i--) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            EndMessage();
               
        }

        
    }
    

    public int PromptActivityTime() {
        Console.Write("How long, in seconds, would you like for your session? ");
        int _activityTime = int.Parse(Console.ReadLine());
        return _activityTime;
       

        // int userTime = int.Parse(Console.ReadLine());
        
    }

}