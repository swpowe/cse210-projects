public class Writing : Assignment
{
    private string _title = "";
    public Writing(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation(){
        return $"{_title} by {_studentName}";
    }
}