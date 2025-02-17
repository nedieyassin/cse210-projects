public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} \n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\n\n");
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        char[] spinnerChars = { '/', '-', '\\', '|' };
        int counter = 0;

        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"{spinnerChars[counter % 4]}");
            counter++;
            Thread.Sleep(250);
            Console.Write("\b \b");

        }
        Console.WriteLine();
    }



    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }



}















// public class Activity
// {
//     protected string _name;
//     protected string _description;
//     protected int _duration;

//     public Activity(string name, string description, int duration)
//     {
//         _name = name;
//         _description = description;
//         _duration = duration;
//     }

//     public void DisplayStartingMessage()
//     {
//         Console.WriteLine($"Starting activity: {_name}");
//     }

//     public void DisplayEndingMessage()
//     {
//         Console.WriteLine($"You completed the activity: {_name}");
//     }
// }

// public class BreathingActivity : Activity
// {
//     public BreathingActivity(string name, string description, int duration) : base(name, description, duration) {}

//     public void Run()
//     {
//         DisplayStartingMessage();
//         // Breathing logic here
//         DisplayEndingMessage();
//     }
// }