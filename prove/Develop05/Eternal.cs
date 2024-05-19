public class Eternal : Goal
{
    public Eternal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _completed = false;
    }
}