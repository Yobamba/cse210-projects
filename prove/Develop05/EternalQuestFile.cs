using System.IO; 

public class EternalQuestFile 
{
    private string _newEntry;
    private string _textFile;

    public void LoadGoals(string userTxt) 
    {
        string filename = userTxt;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");

            foreach (string linea in parts) 
            {
                Console.WriteLine(linea);
            }

            // string firstName = parts[0];
            // string lastName = parts[1];
}
    }

    public void SaveGoals(string userTxt, List<string> simple, List<string> eternal, List<string> checklist, int points) 
    {
        _textFile = userTxt;
        using (StreamWriter outputFile = new StreamWriter(_textFile))
        {
            // You can add text to the file with the WriteLine method

            outputFile.WriteLine($"You have {points} pts");
            foreach (string simp in simple) 
            {
                outputFile.WriteLine(simp);
            }

            foreach (string et in eternal) 
            {
                outputFile.WriteLine(et);
            }

            foreach (string check in checklist) 
            {
                outputFile.WriteLine(check);
            }
            
            
            
        }

        
    }

        
}