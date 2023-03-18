public class EternalGoal : Goal 
{
    private List<EternalGoal> _eternalList = new List<EternalGoal>();
    public EternalGoal() 
    {
        
    }

    public override object CreateGoal(string goalName, string goalDescription, int points, bool isComplete) 
    {
        // _goals.Add(goals);
        EternalGoal newEternalGoal = new EternalGoal();
        newEternalGoal._goalName = goalName;
        newEternalGoal._goalDescription = goalDescription;
        newEternalGoal._points = points;
        newEternalGoal._isComplete = false;
        _eternalList.Add(newEternalGoal);
       
        // _goals.Add(newEternalGoal);
        return newEternalGoal;
    }

    public override void ShowList() 
    {
        for (int j = 0; j < _eternalList.Count; j++) {
       
            if (_eternalList[j]._isComplete == true) 
            {
                Console.WriteLine($"* [x] " + _eternalList[j]);
            } else {
            Console.WriteLine("no flex zone");
            Console.WriteLine($"* [ ] " + _eternalList[j]);
            } }

            
            


        }
    

    public override string ToString() 
    {
        return ($"{_goalName} " + _goalDescription +  " " + " " + _points + " " + _isComplete);
   
    }
    
    public override void RecordEvent() 
    {

    }

    public override void Complete()
    {
        
    }
}