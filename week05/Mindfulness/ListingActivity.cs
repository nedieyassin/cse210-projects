public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration, List<string> prompts) : base(name, description, duration)
    { 
         _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();

        Console.WriteLine("\nList as many responses you can to the following prompt:\n");
        Console.WriteLine($" --- {prompt} --- \n");
        Console.Write("You may begin in:");
        ShowCountDown(3);

        List<string> userResponses = GetListFromUser();
        Console.WriteLine($"You listed {userResponses.Count} items.");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }

        return responses;
    }
}
