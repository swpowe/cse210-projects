public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary(){
        return $"Student Name: {_studentName}\nTopic: {_topic}";
    }
}