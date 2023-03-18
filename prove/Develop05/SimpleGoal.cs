public class SimpleGoal : Goal
{
    // private List<object> _goals; 
    // private string _goalName;
    // private string _goalDescription;
    // private int _points;
    // private string _goalString;
    // private bool _isComplete;

    private List<SimpleGoal> _listSimple = new List<SimpleGoal>();
    

    public SimpleGoal() 
    {
          
    }

    public SimpleGoal(string goalName, string goalDescription, int points, bool isComplete)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
        _isComplete = isComplete;
        
        // _goals.Add($"{_goalName}" + $"{_goalDescription}");
    }

    public override object CreateGoal(string goalName, string goalDescription, int points, bool isComplete) 
    {
        // _goals.Add(goals);
        SimpleGoal newSimpleGoal = new SimpleGoal();
        
        newSimpleGoal._goalName = goalName;
        newSimpleGoal._goalDescription = goalDescription;
        newSimpleGoal._points = points;
        newSimpleGoal._isComplete = isComplete;

         
        
        newSimpleGoal._goalString = $"{_goalName} (_goalDescription)";
        _listSimple.Add(newSimpleGoal);
        // _goals.Add(newSimpleGoal);
       
        return newSimpleGoal;
    }

   
    
    public override void RecordEvent() 
    {

    }

    public override void Complete()
    {
        
    }

    public override void ShowList() 
    {
        for (int j = 0; j < _listSimple.Count; j++) {
       
            if (_listSimple[j]._isComplete == true) 
            {
                Console.WriteLine($"* [x] " + _listSimple[j]);
            } else {
            Console.WriteLine("no flex zone");
            Console.WriteLine($"* [ ] " + _listSimple[j]);
            } }

            
            


        }
    

    public override string ToString() 
    {
        return ($"{_goalName} " + _goalDescription +  " " + " " + _points + " " + _isComplete);
   
    }
    

}
