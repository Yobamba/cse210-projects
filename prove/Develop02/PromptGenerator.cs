public class PromtGenerator
 
{
    //_optionPrompts will contain the list of options for the user
    public string[] _optionPrompts = {"1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"};
     //_userOption will be used to store the number of the option the user selected. 
    public int _userOption;

    public int PromptUser() 
    {   //Print a welcome followed by all the options. 
        Console.WriteLine("Select an action");
        Console.WriteLine("");
        for (int i = 0; i < _optionPrompts.Length; i++) 
        {
            Console.WriteLine(_optionPrompts[i]);
        }
                //Collect the user's option, convert it to an int, and return it. 
            Console.WriteLine("Select an action. ");
            string userString = Console.ReadLine();
            _userOption = int.Parse(userString); 
            return _userOption;

    }
            
}