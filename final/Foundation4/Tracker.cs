public class Tracker
{
    private List<Activity> _activities;
    public Tracker()
    {
        _activities = new();
    }

    public List<Activity> GetActivities()
    {
        return _activities;
    }

    public void AddActivity(Activity activity)
    {
        _activities.Add(activity);
    }
}