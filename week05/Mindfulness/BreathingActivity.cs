public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int elapsed = 0;
        Console.WriteLine("\n");
        while (elapsed < _duration)
        {
            DisplayBreathingVisualizer("Breathe in...", 3, false);
            //ShowCountDown(3);
            DisplayBreathingVisualizer("Now Breathe out...", 3, true);
            //ShowCountDown(3);
            Console.WriteLine("");
            elapsed += 6;
        }
        DisplayEndingMessage();
    }

    private void DisplayBreathingVisualizer(string message, int duration, bool isInhaling)
    {
        int maxArrows = 2 * duration;
        for (int i = 1; i <= duration; i++)
        {
            int arrows;
            if (isInhaling)
                arrows = 2 * i; 
            else
                arrows = 2 * (duration - i + 1);  

            string arrowText = new string(isInhaling ? '>' : '<', arrows);
            string paddedText = arrowText.PadRight(maxArrows);
            Console.Write($"\r{message} [{paddedText}]");  
            Thread.Sleep(1000); 
        }
        Console.WriteLine();  
    }




}