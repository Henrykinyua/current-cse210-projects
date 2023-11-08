using System;
using System.Globalization;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name, squared);



    }

    
          
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;

    }

    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;

    }

    static void DisplayResult(string userName, int squared)
    {
        Console.WriteLine($"{userName}, the square of your favorite number is {squared}");
    }

        
        
 
        


    

}