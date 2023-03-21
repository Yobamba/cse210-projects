public class EternalGoal : Goal 
{
    private List<EternalGoal> _eternalList = new List<EternalGoal>();
    private List<string> _eternalListTxt = new List<string>();
    public EternalGoal() 
    {
        _isComplete = false;
    }

    public override object CreateGoal(string goalName, string goalDescription, int points, bool isComplete) 
    {
        // _goals.Add(goals);
        EternalGoal newEternalGoal = new EternalGoal();
        newEternalGoal._goalName = goalName;
        newEternalGoal._goalDescription = goalDescription;
      
        newEternalGoal._isComplete = false;
        _eternalList.Add(newEternalGoal);
       
        // _goals.Add(newEternalGoal);
        return newEternalGoal;
    }

    public override List<string> ShowList() 
    {
        for (int j = 0; j < _eternalList.Count; j++) {
       
            if (_eternalList[j]._isComplete == true) 
            {
                Console.WriteLine($"[x] " + _eternalList[j]);
                string container = ($"[x] " + _eternalList[j]);
                if (_eternalListTxt.Contains(container) == false) 
                {
                    _eternalListTxt.Add($"[x] " + _eternalList[j]);
                }
                
            } else {
          
            Console.WriteLine($"[ ] " + _eternalList[j]);
            string container2 = ($"[ ] " + _eternalList[j]);
            if (_eternalListTxt.Contains(container2) == false) 
            {
                _eternalListTxt.Add($"[ ] " + _eternalList[j]);
            }
            
            } }

            return _eternalListTxt;

            
            


        }
    

    public override string ToString() 
    {
        return ($"{_goalName} " + _goalDescription +  ". Worth " + _associatedPoints + " pts");
   
    }
    
    public override void RecordEvent() 
    {

    }

    public override void Complete()
    {
        
    }
}