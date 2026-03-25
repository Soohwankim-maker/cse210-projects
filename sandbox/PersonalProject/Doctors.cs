
class Doctor : Person
{
    private string _tools;

    private double _salary;

    public Doctor(string tools, string firstName, string lastName, int age, int weight)
    : base(firstName, lastName, age, weight)
    {
        _tools = tools;
        _salary = 0.0;
    }
    public override  string GetPersonInformation()
    {
        return $"Tools: {_tools}, {base.GetPersonInformation()}";
    }

    public void SetSalary(double salary)
    {
        _salary = salary;
    }

    public override double GetSalary()
    {
        return _salary;
    }
}