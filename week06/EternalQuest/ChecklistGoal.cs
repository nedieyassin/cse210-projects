class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent(ref int score)
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            score += _points;
            if (_amountCompleted == _target)
                score += _bonus;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}