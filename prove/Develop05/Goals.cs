public abstract class Goal 
{
    
    protected string _goalName;
    protected string _goalDescription;
    protected int _associatedPoints;
    protected string _goalString;
    protected bool _isComplete;
    protected List<Object> _listOfGoals = new List<object>();


    

   

    public abstract List<string> RecordEvent(string userEvent, List<string> simple, List<string> eternal, List<string> checklist);
  

    public virtual void Complete() 
    {
        //This method should return true if the goal is completed. 
        //The way you determine if a goal is complete is different for each type of goal.
    }

    public abstract object CreateGoal(string goalName, string goalDescription, int points, bool isComplete);
    public abstract List<string> ShowList();

    
   

    





}