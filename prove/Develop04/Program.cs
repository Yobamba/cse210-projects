using System;

class Program
{
  static void Main(string[] args)
  {
    int userStartOption = 0;
    while (userStartOption != 4) {
      Activity actObj = new Activity();
      actObj.DisplayActivities();
      Console.Write("Select a choice from the menu: ");
      Console.WriteLine();
      int userTiempo;
      userStartOption = int.Parse(Console.ReadLine());
      if (userStartOption == 1) {
        Breathing breath = new Breathing();
        actObj.runActivities(breath);
        userTiempo = breath.PromptActivityTime();
        breath.BreathInNOut(userTiempo);

      }

      else if (userStartOption == 2) {
        Reflecting reflection = new Reflecting();
        actObj.runActivities(reflection);
        userTiempo = reflection.PromptActivityTime();
        reflection.Ponder(userTiempo);
      }

      else if (userStartOption == 3) {
        Listening listen = new Listening();
        actObj.runActivities(listen);
        userTiempo = listen.PromptActivityTime();
        listen.ListenUp(userTiempo);
      }
    }
  }
}