public class Checklist : Goal
{
    private int _bonusTimes, _bonusPoints;
    public Checklist(string type, string name, string description, int points, int bonusTimes, int bonusPoints) : base(type, name, description, points)
    {
        _bonusTimes = bonusTimes;
        _bonusPoints = bonusPoints;
        _completed = false;
    }
}