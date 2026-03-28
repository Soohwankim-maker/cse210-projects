public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus()
    {
        return _isComplete ? "[X] " : "[ ] ";
    }
}