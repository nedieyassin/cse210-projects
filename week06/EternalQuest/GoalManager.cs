class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        while (true)
        {

            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from menu: ");

            switch (Console.ReadLine())
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": return;
                default: Console.WriteLine("Invalid choice, try again."); break;
            }
        }
    }

    private void CreateGoal()
    {

        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());



        switch (type)
        {
            case "1": _goals.Add(new SimpleGoal(name, desc, points)); break;
            case "2": _goals.Add(new EternalGoal(name, desc, points)); break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }

    public string GetProgressBadge()
    {
        if (_score >= 801)
        {
            return "🏆 Champion";
        }
        else if (_score >= 501)
        {
            return "🏅 Gold";
        }
        else if (_score >= 201)
        {
            return "🥈 Silver";
        }
        else if (_score >= 1)
        {
            return "🥉 Bronze";
        }
        else
        {
            return "😞 No Progress";
        }
    }

    private void DisplayPlayerInfo(){
        string badge = GetProgressBadge();
        Console.WriteLine($"\nYou have {_score} points and badge: {badge}");
    }

    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int prevScore = _score;

        _goals[index].RecordEvent(ref _score);
        Console.WriteLine($"Congratulation! You have earned  {_score - prevScore} points");
        Console.WriteLine($"You now have  {_score} points");
    }


    private void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
    }
    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }




    private void SaveGoals()
    {

        Console.Write("What is the filename for the goal file?  ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename for the goal file?  ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename)) return;
        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            _score = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                switch (parts[0])
                {
                    case "SimpleGoal": _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]),bool.Parse(parts[4]) )); break;
                    case "EternalGoal": _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3]))); break;
                    case "ChecklistGoal": _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]))); break;
                }
            }
        }
    }
}