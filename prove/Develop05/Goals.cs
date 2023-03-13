public abstract class Goal 
{
    
    protected string _goalName;
    protected string _goalDescription;
    protected int _points;
    protected string _goalString;
    protected bool _isComplete;


    public void DisplayOptions() 
    {
        Console.WriteLine("You have " + $"{_points}" + " points. ");
        Console.WriteLine("Menu options: ");
        Console.WriteLine("1. Create New Goal. ");
        Console.WriteLine("2. List Goals. ");
        Console.WriteLine("3. Save Goals. ");
        Console.WriteLine("4. Load Goals. ");
        Console.WriteLine("5. Record Event. ");
        Console.WriteLine("6. Quit. ");
        Console.WriteLine();
        // Console.WriteLine("Select a choice from the menu. ");
    }

    public void GoalTypes() 
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal. ");
        Console.WriteLine("2. Eternal Goal. ");
        Console.WriteLine("3. Checklist Goal. ");
        Console.WriteLine();
        Console.WriteLine("Which type of goal would you like to create? ");

    }

    public virtual void RecordEvent() 
    {

    }

    public virtual void Complete() 
    {
        //This method should return true if the goal is completed. 
        //The way you determine if a goal is complete is different for each type of goal.
    }

    public abstract object CreateGoal(string goalName, string goalDescription, int points, bool isComplete);

    
   

    





}