using System;

class Program
{
    static void Main(string[] args)
    {

        string level = "";
        int myGuess = -1;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        while (myGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            myGuess = int.Parse(guess);
            if (myGuess > magicNumber)
            {
                level = "lower";
            }

            else if (myGuess < magicNumber)
            {
                level = "higher";
            }

            else
            {
                level = "YOU GOT IT!!!";
            }
            Console.WriteLine(level);
        }

        


    }
}