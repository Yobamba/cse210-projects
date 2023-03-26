public class ChecklistGoal : Goal 
{
    private int _bonusPoints;
    private int _numberOfChecklistGoals;
    private int _completionNumber;
    private int _checkTimes;
    private List<string> _simpleTxtList = new List<string>();

    private List<ChecklistGoal> _checkGoalList = new List<ChecklistGoal>();


    public ChecklistGoal() 
    {
        _isComplete = false;
    }

    public override object CreateGoal(string goalName, string goalDescription, int points, bool isComplete) 
    {
        // _goals.Add(goals);
        ChecklistGoal newChecklGoal = new ChecklistGoal();
        newChecklGoal._goalName = goalName;
        newChecklGoal._goalDescription = goalDescription;
        newChecklGoal._associatedPoints = points;
        newChecklGoal._isComplete = false;
        newChecklGoal._goalString = $"{_goalName} (_goalDescription)";
        
        _checkGoalList.Add(newChecklGoal);
        // _goals.Add(newChecklGoal);
        return newChecklGoal;
    }

    public object CreateCheckGoal(string goalName, string goalDescription, int points, bool isComplete, int checkT, int bonus) 
    {
        // _goals.Add(goals);
        ChecklistGoal newChecklGoal = new ChecklistGoal();
        newChecklGoal._goalName = goalName;
        newChecklGoal._goalDescription = goalDescription;
        newChecklGoal._associatedPoints = points;
        newChecklGoal._isComplete = false;
        newChecklGoal._goalString = $"{_goalName} (_goalDescription)";
        newChecklGoal._checkTimes = checkT;
        newChecklGoal._bonusPoints = bonus;
        newChecklGoal._completionNumber = 0;
       
        _checkGoalList.Add(newChecklGoal);
        // _goals.Add(newChecklGoal);
        return newChecklGoal;

    }
    public override List<string> RecordEvent(string userEvent, List<string> simple, List<string> eternal, List<string> checklist) 
    {
       
        List<string> newList = new List<string>();
        return newList;
    }

    public override void Complete()
    {
        
    }

    public override List<string> ShowList() 
    {
        for (int j = 0; j < _checkGoalList.Count; j++) {
       
            if (_checkGoalList[j]._isComplete == true) 
            {
                Console.WriteLine($"[x] " + _checkGoalList[j]);
                string container = ($"[x] " + _checkGoalList[j]);
                if (_simpleTxtList.Contains(container) == false) 
                {
                    _simpleTxtList.Add($"[x] " + _checkGoalList[j]);
                }
                
            } else {
         
            Console.WriteLine($"[ ] " + _checkGoalList[j]);
            string container2 = ($"[ ] " + _checkGoalList[j]);
            if (_simpleTxtList.Contains(container2) == false) 
            {
                _simpleTxtList.Add($"[ ] " + _checkGoalList[j]);
            }
            
            } }
        return _simpleTxtList;


            
            


        }
    

    public override string ToString() 
    {
        return ($"{_goalName} " + _goalDescription +  " " + " " + _associatedPoints + " pts " + "-- Currently completed " +  _completionNumber + "/" + _checkTimes + ";");
   
    }
}