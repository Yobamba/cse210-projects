using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers and type 0 when finished. ");

        int userInt = -1;

        int sum = 0;
        int avg = 0;
        while (userInt != 0) {
            if (userInt == -1) {
                userInt = userInt + 1;
                
            }
            int maxNum = 0;
            //userInt will contain the number entered by the user
            userInt = int.Parse(Console.ReadLine());
            // this will add that user number to the list
            numbers.Add(userInt);
            //the sum variable will be used to sum up the numbers of the list as we go
            sum = sum + userInt;
            // this will contain the size of the list
            int numCount = numbers.Count;
            //problem: the list is too long because of that final 0 that's extra. 
            //how do I remove that extra number just before making the division
            // so I don't have that division by 0 error. 
            foreach (int num in numbers) {
            if (num >= maxNum) {
                maxNum = num;
            }
            

        }
        Console.WriteLine($"Max number is {maxNum}");
        
        }
        avg = sum / (numbers.Count - 1);
        // avg = sum / (numCount - 1);
        // Console.WriteLine($"numCount: {numCount}");

    Console.WriteLine($"The sum of the numbers in the list is: {sum} and the average is {avg}. ");
    
    }
}