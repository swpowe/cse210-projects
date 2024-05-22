public class Simple : Goal
{
    public Simple(string type, string name, string description, bool completed, int points) : base(type, name, description, completed, points)
    {
        _completed = false;
    }

}