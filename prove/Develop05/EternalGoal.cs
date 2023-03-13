public class EternalGoal : Goal 
{
    public EternalGoal(bool isComplete) 
    {
        _isComplete = isComplete;
    }

    public override object CreateGoal(string goalName, string goalDescription, int points, bool isComplete) 
    {
        // _goals.Add(goals);
        EternalGoal newEternalGoal = new EternalGoal(false);
        newEternalGoal._goalName = goalName;
        newEternalGoal._goalDescription = goalDescription;
        newEternalGoal._points = points;
        newEternalGoal._isComplete = false;
        newEternalGoal._goalString = $"{_goalName} (_goalDescription)";
        // _goals.Add(newEternalGoal);
        return newEternalGoal;
    }
    
    public override void RecordEvent() 
    {

    }

    public override void Complete()
    {
        
    }
}