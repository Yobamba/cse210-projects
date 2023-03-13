public class GoalList 
{
    private List<Object> _goals = new List<object>(); 

    public void AddGoal(Object goal)  
    {
        _goals.Add(goal);
    }
    public void ListGoals() 
    {
        
        for (int i = 0; i < _goals.Count;i++) 
        {
            // Console.WriteLine($"{i + 1}" +$". {_goals[i]._goalString}");
            Console.WriteLine($"{i + 1}" +$". {_goals[i]}");

            
        }

        // Console.Write(_goals.Count);
       
    }
}