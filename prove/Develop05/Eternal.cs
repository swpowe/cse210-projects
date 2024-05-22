public class Eternal : Goal
{
    public Eternal(string type, string name, string description, bool completed, int points) : base(type, name, description, completed, points)
    {
        _completed = completed;
    }
}