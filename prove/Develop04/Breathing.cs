public class Breathing : Activity
{   
    private string[] _breathingInstructions = {"Breathe in", "Breathe out"};

    
    public void ShowBreathingWelcome() {
        Console.WriteLine("Welcome to this breathing activity. ");
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. ");
        Console.WriteLine();
        Console.WriteLine("Clear your mind and focus on your breathing. ");
    }

    public void ShowAnimation() {
        string[] animationArray = {"|", "/", "-", "\\", "-", "|"};
        for (int i = 0; i <= animationArray.Length; i++) {
            Console.Write($"{animationArray[i]}");
            Thread.Sleep(1000);
            Console.Write("\b \b ");
            
        }
    }

    public string PromptActivityTime() {
        Console.Write("How long, in seconds, would you like for your session? ");
        string userChosenTime = Console.ReadLine();
        return userChosenTime;

        // int userTime = int.Parse(Console.ReadLine());
        
    }
    public void SetActivityTime(int activityTime) {
        _activityTime = activityTime;

    }
}