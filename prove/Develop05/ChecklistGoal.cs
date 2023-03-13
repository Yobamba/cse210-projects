public class ChecklistGoal : Goal 
{
    private int _bonusPoints;
    private int _numberOfChecklistGoals;
    private int _completionNumber = 0;

    public override object CreateGoal(string goalName, string goalDescription, int points, bool isComplete) 
    {
        // _goals.Add(goals);
        ChecklistGoal newChecklGoal = new ChecklistGoal();
        newChecklGoal._goalName = goalName;
        newChecklGoal._goalDescription = goalDescription;
        newChecklGoal._points = points;
        newChecklGoal._isComplete = false;
        newChecklGoal._goalString = $"{_goalName} (_goalDescription)";
        // _goals.Add(newChecklGoal);
        return newChecklGoal;
    }
    public override void RecordEvent() 
    {

    }

    public override void Complete()
    {
        
    }
}