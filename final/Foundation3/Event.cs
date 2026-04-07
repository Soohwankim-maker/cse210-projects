class Event
{
    protected string _title, _description, _date, _time, _address;

    public Event(string title, string desc, string date, string time, string address)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"{_title} - {_description}\n{_date} at {_time}\n{_address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

   public virtual string GetShortDescription()
    {
        return $"{_title} ({this.GetType().Name}) - {_date}";
    }
}