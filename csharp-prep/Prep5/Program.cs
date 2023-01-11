using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string your_name = PromtUserName();
        PromptUserNumber();
        string squared_number = (SquareNumber()).ToString();
       

        DisplayResult(your_name, squared_number);
        static void DisplayWelcome() 
        {
            Console.WriteLine("Welcome to the program! ");

        }

        
    
        static string PromtUserName() 
        {
            Console.Write("What's your name? ");
            string user_name = Console.ReadLine();
            // string text_for_user = $"Welcome {user_name}";
            return user_name;

        }

        

        static int PromptUserNumber() 
        {
            Console.WriteLine("Enter your favorite number. ");
            int favNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your favorite number is {favNumber}");
            
            return favNumber;
        }
        
        

        static int SquareNumber()
        {
            Console.WriteLine("Enter a number to square up. ");
            int number_to_square = int.Parse(Console.ReadLine());
            int squared = number_to_square * number_to_square;
            
            return squared;
        }
        
    }

        static void DisplayResult(string name, string number) 
        {
            Console.Write($"{name}, the square of your number is {number}. ");

            
        }

    




}