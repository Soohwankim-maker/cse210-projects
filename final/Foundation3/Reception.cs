class Reception : Event
{
    private string _email;

    public Reception(string title, string desc, string date, string time, string address, string email)
        : base(title, desc, date, time, address)
    {
        _email = email;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP: {_email}";
    }
}