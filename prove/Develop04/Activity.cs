public class Activity 
{
    protected string _activityName;

    protected string[] _activityList = {"Breathing activity", "Reflection activity", "Listening activity"};

    protected string _activitySpecifications;
    protected int _activityTime;

    public Activity() {

    }

    public Activity(string activitySpecifications, int activityTime) {
        
        _activitySpecifications = activitySpecifications;
        _activityTime = activityTime;
        
    }

    // public void Timer() {
    //     Console.WriteLine("Get ready...");
    //     for (int i = 5; i > 0; i--) {
    //         Console.WriteLine(i);
    //         Console.Write();
    //     }
    // }

   

    public void StartMessage() {
        Console.WriteLine("Welcome to this " + $"{_activityName}. ");
        Thread.Sleep(2000);
        Console.WriteLine();
        Console.WriteLine(_activitySpecifications);
    }

    public void EndMessage() {
        Console.WriteLine();
        Console.WriteLine("Thank you for completing this " + $"{_activityName}. ");
        Console.WriteLine();
        Thread.Sleep(2000);
    }


    public void ShowAnimation() {
        string[] animationArray = {"|", "/", "-", "\\", "|", "-", "\\"};
        Console.WriteLine("Get ready...");
        for (int i = 0; i <= 6; i++) {
            Console.Write($"{animationArray[i]}");
            Thread.Sleep(700);
            Console.Write("\b \b");
            
        }
        Console.WriteLine();
    }

    public void DisplayActivities() {
        Console.WriteLine("Menu options: ");
        int first = 1;
        for (int i = 0; i <3; i++) {
            Console.WriteLine($"{first}." + _activityList[i]);
            first = first + 1;
        }
        Console.WriteLine("4. Quit");
        Console.WriteLine();
    }
}