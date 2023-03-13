using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal simpGoal = new SimpleGoal();
        Object container = simpGoal.CreateGoal("Bed time", "Go to bed by 10:50", 50, false);
        GoalList gList = new GoalList();
        gList.AddGoal(container);
        gList.ListGoals();
        
        // simpGoal._goals.Add(container);
        // simpGoal.ListGoals();
        
    }
}