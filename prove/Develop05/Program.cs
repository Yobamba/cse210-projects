using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal simpGoal = new SimpleGoal();
        simpGoal.DisplayOptions();
        Object container = simpGoal.CreateGoal("Bed time", "Go to bed by 10:50", 80, true);
        Object container2 = simpGoal.CreateGoal("Nap time! ", "Go to bed by 04:50", 50, false);

        EternalGoal etGoal = new EternalGoal();
        Object etContainer = etGoal.CreateGoal("Read", "Read books and learn", 50, false);

        ChecklistGoal checkGoal = new ChecklistGoal();
        Object checkContainer = checkGoal.CreateGoal("Finish assignments", "Complete CSE and ENG assignments", 100, false);
        etGoal.ShowList();
        checkGoal.ShowList();
        simpGoal.ShowList();


        // GoalList gList = new GoalList();
        // gList.AddGoal(container);
        // gList.AddGoal(container2);
        // List<Object> goalList = new List<Object>();
        // gList.ListGoals();
        
        // simpGoal._goals.Add(container);
        // simpGoal.ListGoals();
        
    }
}