using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment tarea = new Assignment("Ednilson", "CSE 210 Prove");
        // string homeworkSummary = tarea.GetSummary();
        // Console.WriteLine(homeworkSummary);

        // MathAssignment tareaDeMat = new MathAssignment("Ednilson", "CSE 210 Prove", "3.7", "1-4");
        // string mathSummary = tareaDeMat.GetSummary();
        // Console.WriteLine(mathSummary);
        // string mathWork= tareaDeMat.GetHomeworkList();
        // Console.WriteLine(mathWork);

        WritingAssignment tareaEscrita = new WritingAssignment("Ednilson", "programming", "programming with classes");
        string infoDeLaTarea = tareaEscrita.GetWritingInformation();
        Console.WriteLine(infoDeLaTarea);
    }
}