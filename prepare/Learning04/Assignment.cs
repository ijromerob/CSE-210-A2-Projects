public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string topic, string name)
    {
        _topic = topic;
        _studentName = name;
    }
    
    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }

   
    public string GetStudentName()
    {
        string name = _studentName;
        return name;
    }
}