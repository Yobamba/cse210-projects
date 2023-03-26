using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        SimpleGoal simpGoal = new SimpleGoal();
        EternalGoal eternal = new EternalGoal();
        ChecklistGoal check = new ChecklistGoal();

        List<Goal> globalList = new List<Goal>();
       
        GoalList listOfGoals = new GoalList();
        // listOfGoals.ListGoals
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
                
            } else if (userChose == 4) 
            {
                Console.Write("What is the name of the txt file that will store the goal? ");
                string userLoadFile = Console.ReadLine();
                goalFile.LoadGoals(userLoadFile);
                
            } else if (userChose == 5) 
            {
                Console.WriteLine("The goals are: ");
                List<string> combinedList = listOfGoals.ListGoals(simpleText, eternalText, checkText);
                int selectedEvent = int.Parse(Console.ReadLine());
                string[] newArray = combinedList.ToArray();
                for (int k = 0; k < combinedList.Count(); k++) 
                {
                    if (combinedList[k] == combinedList[selectedEvent - 1]) 
                    {
                        simpGoal.RecordEvent(combinedList[selectedEvent - 1], simpleText, eternalText, checkText);
                    //     combinedList[k].RecordEvent(combinedList[selectedEvent - 1], simpleText, eternalText, checkText);
                    // }
                    Console.WriteLine(combinedList[k]);
                }
                Console.WriteLine(newArray.ElementAt(selectedEvent));
                // foreach(Goal g in globalList) 
                // {
                //     g.
                // }
               
                
                

           
                if (selectedEvent == 1) 
                {

                }


                
                
            }
        

           
          


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

}