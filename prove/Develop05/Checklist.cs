public class Checklist : Goal
{
    private int _bonusTimes, _bonusPoints, _completedTimes;
    private bool _bonusAchieved = false;

    public Checklist(string type, string name, string description, int points, int bonusTimes, int bonusPoints) : base(type, name, description, points)
    {
        _bonusTimes = bonusTimes;
        _bonusPoints = bonusPoints;
        _completed = false;
        _completedTimes = 0;
    }

    public override void DisplayGoal()
    {
        string completedText = "[ ]";

        // if (_completed && _type != "Eternal") //!! this should probalby come out. the overried knows which type it is
        // {
        //     completedText = "[X]";
        // }
        // if (_completed && _type == "Eternal")
        // {
        //     completedText = "[-]";
        // }
        if (_completed) completedText = "[X]";

        Console.WriteLine($"{_type}:{completedText} {_name} ({_description}) -- Currently completed: {_completedTimes} / {_bonusTimes}");
    }

    public override void MarkCompleted()
    {
        _completed = true;
        if (_completedTimes == _bonusTimes)
        {
            _completedTimes = 0;
            _bonusAchieved = true;
        }
        else
        {
            _completedTimes++;
        }

    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public override string GetGoalDetails()
    {
        string details = $"{_type}|{_name}|{_description}|{_points}|{_bonusTimes}|{_bonusPoints}";
        return details;
    }

}