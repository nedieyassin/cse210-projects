using System;

class Program
{
    static void Main(string[] args)
    {

        string letter = "";

        Console.Write("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        Console.WriteLine($"Your letter grade is: {letter}");
        if(gradePercentage>=70){
            Console.WriteLine("Congratulations, you have passed!");
        }else{
            Console.WriteLine("You have failed, work harder next time.");
        }

    }
}