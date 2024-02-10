public abstract class  Goal
{
    //This will be the base class
    //These are attributes that will be used in all the derived classes

    protected string _shortName;
    protected string _description;
    protected int _points;

//Constructor -----------------
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

// Behaviours -------------------
    public abstract int RecordEvent();
    public abstract bool IsComplete();

    //Since it is a method that is only changed in Checklist, then it will be virtual method
    public virtual string GetDetailsString()
    {
        string text;
        if (IsComplete())
        {
            text = $"[X] {_shortName} ({_description})";
        }
        else
        {
            text = $"[ ] {_shortName} ({_description})";
        }
        return text;
    }
    public abstract string GetStringRepresentation();
    public string GetName()
    {
        return _shortName;
    }
}