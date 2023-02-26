public class Activity 
{
    private string[] _activityName = {"Breathing Activity", "Reflection Activity", "Listening Activity"};
    private string _activitySpecifications;
    protected int _activityTime;

    public Activity() {

    }

    public Activity(string activitySpecifications, int activityTime) {
        
        _activitySpecifications = activitySpecifications;
        _activityTime = activityTime;
        
    }

    public void Timer() {
        Console.WriteLine("Get ready...");
        for (int i = 5; i > 0; i--) {
            Console.WriteLine(i);
            Console.Write("6o");
        }
    }

    public void StartMessage(int activityNumber) {
        Console.WriteLine("Welcome to this" + $"{_activityName[activityNumber]}. ");
    }

    public void DisplayActivities() {
        Console.WriteLine("Menu options: ");
        int first = 1;
        for (int i = 0; i < _activityName.Length; i++) {
            Console.WriteLine($"{first}." + _activityName[i]);
            first = first + 1;
        }
        Console.WriteLine("4. Quit");
    }
}