public class GoalList
{
    private List<string> _goalList = new List<string>();
    private List<Object> _goals = new List<Object>(); 
   
    Object placeHolder = new Object();

    

   
    public void AddGoal(Object goal)  
    {
        _goals.Add(goal);
    }

   
    public List<string> ListGoals(List<string> simple, List<string> eternal, List<string> checklist) 

    {
        foreach (string simp in simple) 
        {
           
            if (_goalList.Contains(simp) == false) 
            {
                _goalList.Add(simp);
            }
          
        }

        foreach (string et in eternal) 
        {
            if (_goalList.Contains(et) == false) 
            {
                _goalList.Add(et);
            }
            
        }

        foreach (string check in checklist) 
        {
            if (_goalList.Contains(check) == false) 
            {
                _goalList.Add(check);
            }
           
        }
        
        for (int i = 0; i < _goals.Count;i++) {
           
        
            // Console.WriteLine($"{i + 1}" +$". {_goals[i]._goalString}");
            // Console.WriteLine($"{i + 1}" +$". {_goals[i]._goalDescription}");
            // Object currentO = _goals.goalDescription;
            // Console.WriteLine($"{i + 1}" +$". {_goals[i].goalDescription}");
            

            
        }

        Console.Write(_goals.Count);
        for (int k = 0; k < _goalList.Count(); k++) 
        {
            Console.WriteLine($"{k + 1}. {_goalList[k]}");
        }

        Console.Write("Select the event you want to complete. ");
        return _goalList;
       
    }
}