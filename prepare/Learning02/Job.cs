public class Job {
    public string _companyName = "";
    public string _jobTitle = "";
    public int _startYear = 0000;
    public int _endYear = 0000;

    public Job() {

    }

    public void DisplayJobDetails() {
        Console.Write($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear} ");
        Console.WriteLine();
    }
}