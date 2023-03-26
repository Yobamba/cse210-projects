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
        newEternalGoal._associatedPoints = points;
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
        return ($"{_goalName} " + _goalDescription +  ". Worth " + _associatedPoints + " pts" + ";");
   
    }
    
    public override List<string> RecordEvent(string userEvent, List<string> simple, List<string> eternal, List<string> checklist) 
    {
        List<string> combinedList = new List<string>();
        foreach (string simp in simple) 
        {
            combinedList.Add(simp);
        }

        foreach (string et in eternal) 
        {
            combinedList.Add(et);
        }

        foreach (string check in checklist) 
        {
            combinedList.Add(check);
        }

        _eternalListTxt = combinedList;
        for (int j = 0; j < _eternalListTxt.Count(); j++) 
        {
            if (_eternalListTxt[j] == userEvent) 
            {
                _eternalList[j]._isComplete = true;
                _eternalListTxt[j] = $"[x] " + _eternalList[j];
            }
            
        } return combinedList;
    }

    public override void Complete()
    {
        
    }
}