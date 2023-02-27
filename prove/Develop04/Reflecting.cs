public class Reflecting : Activity
{
    private string[] _ponderInstructions = {"Think of a time when you stood up for someone else. ", "Think of a time when you did something really difficult. ", "Think of a time when you helped someone in need. ", "Think of a time when you did something truly selfless. "};
    private string[] _ponderQuestions = {"Why was this experience meaningful to you? ", "Have you ever done anything like this before?", "How did you get started? ", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful? ", "What is your favorite thing about this experience? ", "What could you learn from this experience that applies to other situations? ", "What did you learn about yourself through this experience? ", "How can you keep this experience in mind in the future? "};
    public Reflecting() 
    {
        _activitySpecifications = "This activity will help you reflect on times of your life when you have shown strength, and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.  ";
        _activityName = "Reflection activity";
    }

    public void Ponder() {
        Random rando = new Random();
        string[] ponderInstructions = _ponderInstructions;
        string[] ponderQuestions = _ponderQuestions;
        int randomInt = rando.Next(ponderInstructions.Length);

        Console.WriteLine(ponderInstructions[randomInt]);
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience. ");
        Thread.Sleep(6000);
        Console.Write("> ");
        Console.Write(ponderQuestions[randomInt]);
        Spinner();
        Thread.Sleep(6000);
        EndMessage();


    }

}