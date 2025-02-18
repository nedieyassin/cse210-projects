using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();


        activities.Add(new Running(new DateTime(2025, 1, 13), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2025, 1, 25), 45, 20.0));
        activities.Add(new Swimming(new DateTime(2025, 2, 14), 25, 20, 50));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}