public class SimpleGoal : Goal
{
    // private List<object> _goals; 
    // private string _goalName;
    // private string _goalDescription;
    // private int _points;
    // private string _goalString;
    // private bool _isComplete;

    

    public SimpleGoal() 
    {
          
    }

    public SimpleGoal(string goalName, string goalDescription, int points, bool isComplete)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
        _isComplete = isComplete;
        // _goals.Add($"{_goalName}" + $"{_goalDescription}");
    }

    public override object CreateGoal(string goalName, string goalDescription, int points, bool isComplete) 
    {
        // _goals.Add(goals);
        SimpleGoal newSimpleGoal = new SimpleGoal();
        newSimpleGoal._goalName = goalName;
        newSimpleGoal._goalDescription = goalDescription;
        newSimpleGoal._points = points;
        
        newSimpleGoal._isComplete = false;
        newSimpleGoal._goalString = $"{_goalName} (_goalDescription)";

        // _goals.Add(newSimpleGoal);
        return newSimpleGoal;
    }
    
    public override void RecordEvent() 
    {

    }

    public override void Complete()
    {
        
    }

    

    // public override void CreateGoal()
    // {
    //     throw new NotImplementedException();
    // }
}