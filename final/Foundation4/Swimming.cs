class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming - {_laps} laps";
    }
}