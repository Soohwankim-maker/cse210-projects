class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string desc, string date, string time, string address, string weather)
        : base(title, desc, date, time, address)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather: {_weather}";
    }
}