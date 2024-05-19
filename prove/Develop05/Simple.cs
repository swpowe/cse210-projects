public class Simple : Goal
{
    public Simple(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _completed = false;
    }

}