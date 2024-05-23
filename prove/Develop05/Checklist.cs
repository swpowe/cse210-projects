public class Checklist : Goal
{
    private int _bonusTimes, _bonusPoints, _completedTimes;
    private bool _bonusAchieved = false;

    public Checklist(string type, string name, string description, bool completed, int points, int completedTimes, int bonusTimes, int bonusPoints) : base(type, name, description, completed, points)
    {
        _bonusTimes = bonusTimes;
        _bonusPoints = bonusPoints;
        _completed = completed;
        _completedTimes = completedTimes;
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
        _completedTimes++;
        if (_completedTimes == _bonusTimes)
        {
            // _completedTimes = 0;
            _bonusAchieved = true;
            // _points = _points + _bonusPoints;
        }
        else
        {
            // _bonusAchieved = false;
            // _completedTimes++;
            _bonusAchieved = false;
        }

    }


    public override string GetGoalDetails()
    {
        string details = $"{_type}|{_name}|{_description}|{_completed}|{_points}|{_completedTimes}|{_bonusTimes}|{_bonusPoints}";
        return details;
    }


    public override int GetPoints()
    {
        if (_bonusAchieved)
        {
            return _bonusPoints + _points;
        }
        else
        {
            return _points;
        }

        // return base.GetPoints();
    }


}