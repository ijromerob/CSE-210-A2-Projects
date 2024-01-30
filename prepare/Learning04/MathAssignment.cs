public class MathAssignment: Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string section, string problems,string topic, string name) : base(topic,name)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        string hwlist = $"Section {_textbookSection} Problems {_problems}";
        return hwlist;
    }

}