public class Run 
{   
    Points points = new Points();
    
    public int GoalTypes() 
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal. ");
        Console.WriteLine("2. Eternal Goal. ");
        Console.WriteLine("3. Checklist Goal. ");
        Console.WriteLine();
        Console.Write("Which type of goal would you like to create? ");
        int userGoalType = int.Parse(Console.ReadLine());
       
        return userGoalType;


    }
    public override string ToString() 
    {
        return ($"{points} - " +  " pts" );
   
    }

   
    public int DisplayOptions() 
    {
        
        Console.WriteLine();
        Console.WriteLine("Menu options: ");
        Console.WriteLine("1. Create New Goal. ");
        Console.WriteLine("2. List Goals. ");
        Console.WriteLine("3. Save Goals. ");
        Console.WriteLine("4. Load Goals. ");
        Console.WriteLine("5. Record Event. ");
        Console.WriteLine("6. Quit. ");
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
        int userOption = int.Parse(Console.ReadLine());
        return userOption;


        // Console.WriteLine("Select a choice from the menu. ");
    }
}