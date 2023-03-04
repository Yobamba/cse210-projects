public class Listening : Activity
{
  private string[] _listeningInstructions = {
    "-- Who are people that you appreciate? -- ",
    "-- What are personal strengths of yours? --",
    "-- Who are people that you have helped this week? --",
    "-- When have you felt the Holy Ghost this month? --",
    "-- Who are some of your personal heroes? --"
  };
  public Listening()
  {
    _activitySpecifications =
      "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area . ";
    _activityName = "Listening activity";
  }

  public void ListenUp(int activityTime)
  {
    Console.Clear();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(activityTime);
    string userWrote;
    List<string> userQuotes = new List<string>();

    while (DateTime.Now < endTime) {
      Console.WriteLine(
        "List as many responses as you can to the following prompt: ");
      Console.WriteLine();
      Random rando = new Random();

      string[] listeningInstructions = _listeningInstructions;
      int randomInt = rando.Next(listeningInstructions.Length);
      int randomInt2 = rando.Next(listeningInstructions.Length);
      int[] randoList = {};
      randoList.Append(randomInt);
      Console.WriteLine(listeningInstructions[randomInt]);
      Console.Write($"You may begin in: ");
      for (int i = 5; i > 0; i--) {
        Console.Write(i);
        Thread.Sleep(700);
        Console.Write("\b \b");
      }

      while (DateTime.Now < endTime) {
        Console.WriteLine();
        Console.Write("> ");
        userWrote = Console.ReadLine();
        userQuotes.Add(userWrote);
      }
    }
    EndMessage();
    Console.WriteLine("You entered " + $"{userQuotes.Count} items. ");
  }
}