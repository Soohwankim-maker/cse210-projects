using System;

public class EternalGoal : Goal
{
    private int _streak = 0;
    private DateTime _lastDate;

    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent()
    {
        DateTime today = DateTime.Now;

        if (_lastDate.Date == today.AddDays(-1).Date)
        {
            _streak++;
        }
        else
        {
            _streak = 1;
        }

        _lastDate = today;

        int bonus = (_streak % 5 == 0) ? 50 : 0;

        return _points + bonus;
    }

    public override bool IsComplete() => false;

    public override string GetStatus()
    {
        return $"[∞] Streak: {_streak}";
    }
}