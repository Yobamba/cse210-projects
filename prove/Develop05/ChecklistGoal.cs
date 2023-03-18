public class ChecklistGoal : Goal 
{
    private int _bonusPoints;
    private int _numberOfChecklistGoals;
    private int _completionNumber = 0;

    private List<ChecklistGoal> _checkGoalList = new List<ChecklistGoal>();


    public override object CreateGoal(string goalName, string goalDescription, int points, bool isComplete) 
    {
        // _goals.Add(goals);
        ChecklistGoal newChecklGoal = new ChecklistGoal();
        newChecklGoal._goalName = goalName;
        newChecklGoal._goalDescription = goalDescription;
        newChecklGoal._points = points;
        newChecklGoal._isComplete = false;
        newChecklGoal._goalString = $"{_goalName} (_goalDescription)";
        _checkGoalList.Add(newChecklGoal);
        // _goals.Add(newChecklGoal);
        return newChecklGoal;
    }
    public override void RecordEvent() 
    {

    }

    public override void Complete()
    {
        
    }

    public override void ShowList() 
    {
        for (int j = 0; j < _checkGoalList.Count; j++) {
       
            if (_checkGoalList[j]._isComplete == true) 
            {
                Console.WriteLine($"* [x] " + _checkGoalList[j]);
            } else {
            Console.WriteLine("no flex zone");
            Console.WriteLine($"* [ ] " + _checkGoalList[j]);
            } }

            
            


        }
    

    public override string ToString() 
    {
        return ($"{_goalName} " + _goalDescription +  " " + " " + _points + " " + _isComplete);
   
    }
}