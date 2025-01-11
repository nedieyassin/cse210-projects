using System;

class Program
{

    static string DisplayWelcome()
    {

        return "Welcome to the program!";
    }


    static string PromptUserName()
    {

        Console.Write("Please enter your name: ");
        string fullName = Console.ReadLine();

        return fullName;
    }


    static int PromptUserNumber()
    {

        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }


    static int SquareNumber(int number)
    {
        return (int)Math.Pow(number, 2);
    }

    static void DisplayResult(string fullName, int number)
    {
        Console.WriteLine($"{fullName}, the square of your number is {number}");
    }



    static void Main(string[] args)
    {
        DisplayWelcome();
        string fullName = PromptUserName();
        int number = PromptUserNumber();
        int sqNumber = SquareNumber(number);
        DisplayResult(fullName, sqNumber);

    }
}