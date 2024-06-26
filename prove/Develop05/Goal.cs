public class Goal
{
    protected string _name, _description;
    protected int _points;
    protected string _type;
    protected bool _completed;
    public Goal(string type, string name, string description, bool completed,int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _completed = completed;
    }

    // virtual with defaults to display name, description?
    public virtual void DisplayGoal()
    {
        string completedText = "[ ]";

        if (_completed && _type != "Eternal")
        {
            completedText = "[X]";
        }
        if (_completed && _type == "Eternal")
        {
            completedText = "[-]";
        }

        Console.WriteLine($"{_type}:{completedText} {_name} ({_description})");
    }

    public virtual string GetGoalDetails()
    {
        string details = $"{_type}|{_name}|{_description}|{_completed}|{_points}";
        return details;
    }

    public virtual void MarkCompleted()
    {
        _completed = true;
    }

    public virtual int GetPoints()
    {
        return _points;
    }

    public string GetGoalType()
    {
        return _type;
    }

    // virtual add to list with overloads of additional types?
}