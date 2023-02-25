using System.IO; 
public class Journall
{
    string[] _journalOption = {"1. Save entry", "2. Display recorded entries", "3. Load entries", "4. Exit"};
    int _userOption;
    public string _entry = "";

    public void Display() 
    {
        for (int i = 0; i < _journalOption.Length; i++ ) 
        {
            Console.WriteLine(_journalOption[i]);
        }
        Console.WriteLine("Select one of the options. ");
        _userOption = int.Parse(Console.ReadLine());
       
    }
    public string journal_file = "journalEntry.txt";
    
    public void SaveToFile(string _entry)
    {
        using (StreamWriter outputFile = new StreamWriter(journal_file)) 
        {

            // You can add text to the file with the WriteLine method
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            outputFile.WriteLine($"{dateText} -{_entry}");
            
        
        }
        
        
        
    }
    
    string[] lines = System.IO.File.ReadAllLines("journalEntry.txt");
    public void DisplayEntries()
    {

        foreach (string line in lines) 
        
        {
            string[] parts = line.Split(",");
            Console.WriteLine(parts[0]);

            // string firstName = parts[0];
            // string lastName = parts[1];
        }

        
    }


}