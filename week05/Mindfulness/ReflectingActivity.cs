public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;

    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($" --- {prompt} --- \n");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following as they related to this experience");
        Console.Write("You may begin in:");
        ShowCountDown(3);
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write($"> {GetRandomQuestion()}");
            ShowSpinner(5);
            elapsed += 5;
        }
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }
}