class Running : Activity
{
    private double _miles;

    public Running(string date, int minutes, double miles) : base(date, minutes)
    {
        _miles = miles;
    }

    public override string GetSummary()
    {
        double speed = (_miles / _minutes) * 60;
        double pace = _minutes / _miles;

        return $"{_date} Running ({_minutes} min) - Distance: {_miles} miles, Speed: {speed:0.0} mph, Pace: {pace:0.0} min/mile";
    }
}