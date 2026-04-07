class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string desc, string date, string time, string address, string speaker, int capacity)
        : base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Lecture: {_title} on {_date}";
    }
}