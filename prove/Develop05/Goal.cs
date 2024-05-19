public class Goal
{
    protected string _name, _description;
    protected int _points;
    protected string _type;
    protected bool _completed;

    protected List<Goal> _goals;
    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _goals = new(); //!! is this right?
    }

    // virtual with defaults to display name, description?

    // virtual add to list with overloads of additional types?

    public virtual void AddToList(Goal goal){
        _goals.Add(goal);
    }
}