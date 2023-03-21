using System;

class Program
{
    static void Main(string[] args)
    {
        
        SimpleGoal simpGoal = new SimpleGoal();
        ChecklistGoal check = new ChecklistGoal();
        EternalGoal eternal = new EternalGoal();
        EternalQuestFile goalFile = new EternalQuestFile();
        Points tracker = new Points();
        Run startingObj = new Run();
        int userChose = 0;
        int userType = 0;

        List<string> simpleText = new List<string>();
        List<string> eternalText = new List<string>();
        List<string> checkText = new List<string>();
        

        while (userChose != 6) 
        {   
            Console.WriteLine("You have " + $"{tracker.GetPoints()}" + " points. ");
            userChose = startingObj.DisplayOptions();

            if (userChose == 1) 
            {
                userType = startingObj.GoalTypes();
                if (userType == 1) 
                {
                    Console.Write("What is the name of your goal? ");
                    string userGoalName = Console.ReadLine();

                    Console.Write("What is a short description of your goal? ");
                    string userDescript = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int goalPoints = int.Parse(Console.ReadLine());


                    simpGoal.CreateGoal(userGoalName, userDescript, goalPoints, false);
                    
                    tracker.AddPoints(goalPoints);
                    
                } else if (userType == 2) 
                {
                    Console.Write("What is the name of your goal? ");
                    string userGoalName = Console.ReadLine();

                    Console.Write("What is a short description of your goal? ");
                    string userDescript = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int goalPoints = int.Parse(Console.ReadLine());


                    eternal.CreateGoal(userGoalName, userDescript, goalPoints, false);
                    
                    tracker.AddPoints(goalPoints);
                    
                } else if (userType == 3) 
                {
                    Console.Write("What is the name of your goal? ");
                    string userGoalName = Console.ReadLine();

                    Console.Write("What is a short description of your goal? ");
                    string userDescript = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int goalPoints = int.Parse(Console.ReadLine());

                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int checkTimes = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPts = int.Parse(Console.ReadLine());


                    check.CreateCheckGoal(userGoalName, userDescript, goalPoints, false, checkTimes, bonusPts);
                    
                    tracker.AddPoints(goalPoints);
                    
                }

            } else if (userChose == 2) 
            {
                simpleText = simpGoal.ShowList();
                eternalText = eternal.ShowList();
                checkText = check.ShowList();
                
            } else if (userChose == 3) 
            {
                Console.Write("What is the name of the txt file that will store the goal? ");
                string userFile = Console.ReadLine();
                goalFile.SaveGoals(userFile, simpleText, eternalText, checkText, tracker.GetPoints());
                
            }
        

            EternalGoal etGoal = new EternalGoal();
           
          


            // GoalList gList = new GoalList();
            // gList.AddGoal(container);
            // gList.AddGoal(container2);
            // List<Object> goalList = new List<Object>();
            // gList.ListGoals();
            
            // simpGoal._goals.Add(container);
            // simpGoal.ListGoals();
            }
        
        
        
    }
}