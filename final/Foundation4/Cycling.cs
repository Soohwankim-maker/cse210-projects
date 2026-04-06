class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling - {_speed} mph";
    }
}