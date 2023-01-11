using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();

        int randNumber = randomGenerator.Next(10, 21);
        Console.WriteLine(randNumber);
        
        
        int guessInt = -1;
        Console.Write("Now guess what the magic number is. ");
        while (guessInt != randNumber) {

            
          
            
            string guess = Console.ReadLine();
            guessInt = int.Parse(guess);

            if (guessInt == randNumber) {
                Console.Write("Correct! ");
            }
            else if (guessInt < randNumber) {
                Console.Write("Wrong. Go higher. ");
            }

            else if (guessInt > randNumber) {
                Console.Write("Wrong. Go lower. ");
            }
        }
    }
}