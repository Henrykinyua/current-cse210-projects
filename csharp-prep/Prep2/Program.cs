using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage ");
        string grade = Console.ReadLine();
        int myGrade = int.Parse(grade);

        string letter = "";

        if (myGrade >= 90)
        {
            letter = "A";
        }

        if (myGrade >= 80)
        {
            letter = "B";
        }

        else if (myGrade >= 70)
        {
            letter = "C";
        }

        else if (myGrade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if  (myGrade >= 70)
        {
            Console.WriteLine("CONGRATULATION!!! YOU HAVE PASSED THE COURSE");
        }
        
        if (myGrade < 70)
        {
            Console.WriteLine("SORRY FOR THE FAIL, THERE IS STILL NEXT TIME TO TRY AGAIN");

        }

    }
}