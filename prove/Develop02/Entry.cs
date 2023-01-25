public class Entry
{
    public string[] _question = {"Who was the most interesting person I interacted with today?", 
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"};


    public string _userEntry;

    public string DisplayQuestion() 
    {
        Random rando = new Random();
        int randomNumber = rando.Next(_question.Length);
        string chosenQuestion = _question[randomNumber];
        Console.WriteLine(chosenQuestion);
        Console.WriteLine("Type away! ");
        string userWrote = Console.ReadLine();

        _userEntry = $"{chosenQuestion} : {userWrote}";
        Console.WriteLine(_userEntry);
        return _userEntry;
        
    }
}