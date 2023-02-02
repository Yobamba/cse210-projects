using System;

class Program
{
    static void Main(string[] args)
    {
        Fracao fraction1 = new Fracao();
        Fracao fraction2 = new Fracao(5);
        Fracao fraction3 = new Fracao(5, 2);

        Console.WriteLine(fraction1.GetBottom());
        fraction1.SetBottom(1);
        Console.WriteLine(fraction1.GetBottom());
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());




        

    }
}