using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int guessedNumber = 0;
        int magicNumber = randomGenerator.Next(1, 100);

        Console.WriteLine("Guess The Magic Number");

        while (magicNumber != guessedNumber)
        {
            Console.Write("What is your guess?");
            guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessedNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }

        Console.WriteLine("You guessed it!");

    }
}