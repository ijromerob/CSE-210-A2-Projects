public class EternalGoal:Goal
{
    //There will not be any attributes
    
    // Constructor: it uses the constructor of the base class
    public EternalGoal(string name, string description, int points):base(name, description, points)
    {}

    // Behaviours --------------------
    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        bool neverComplete = false;
        return neverComplete;

    }

    public override string GetStringRepresentation()
    {
        string text;
        text = $"EternalGoal~{_shortName}~{_description}~{_points}";
        return text;
    }
}