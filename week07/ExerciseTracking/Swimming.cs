class Swimming : Activity
{
    private int _laps;
    private double _poolLength;

    public Swimming(DateTime date, int minutes, int laps, double poolLength) : base(date, minutes)
    {
        _laps = laps;
        _poolLength = poolLength / 1000; // Convert poolLength to km from meters

    }

    public override double GetDistance()
    {
        return _laps * _poolLength;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetMinutes() * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}