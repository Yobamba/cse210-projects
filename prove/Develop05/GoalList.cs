public class GoalList : Goal
{
    private List<Object> _goals = new List<Object>(); 
    Object placeHolder = new Object();

    

   public override object CreateGoal(string goalName, string goalDescription, int points, bool isComplete) 
    {
        // _goals.Add(goals);
        // goalDescription = _goalDescription;



        // _goals.Add(newSimpleGoal);
        return 0;
        
    }

    public void AddGoal(Object goal)  
    {
        _goals.Add(goal);
    }

    public override void ShowList() 
    {
        string x = "x";
    }
    public List<Object> ListGoals() 

    {
        Console.WriteLine("Testing, testing");
        
        for (int i = 0; i < _goals.Count;i++) {
           
        
            // Console.WriteLine($"{i + 1}" +$". {_goals[i]._goalString}");
            // Console.WriteLine($"{i + 1}" +$". {_goals[i]._goalDescription}");
            // Object currentO = _goals.goalDescription;
            // Console.WriteLine($"{i + 1}" +$". {_goals[i].goalDescription}");
            

            
        }

        Console.Write(_goals.Count);
        return _goals;
       
    }
}