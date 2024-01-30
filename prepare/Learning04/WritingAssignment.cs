public class WritingAssignment:Assignment
{
    private string _title;

    public WritingAssignment(string title, string name, string topic):base(topic,name)
    {
        _title = title;
    }

    public string GetHomeworkList()
    {
        string hwlist = $"{_title} by {GetStudentName()}";
        return hwlist;
    }
}