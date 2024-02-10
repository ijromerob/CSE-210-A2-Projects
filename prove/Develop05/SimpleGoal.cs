public class SimpleGoal:Goal
{
   // This will be the code of the class for a simple goal
   //Attributes -----------
   private bool _isComplete = false;

    //Constructor
    public SimpleGoal(string name, string description, int points): base(name,description,points)
    {
        //There is no need to add any code here since it will take the informtion from the base constructor
    }

    //behaviours 
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    public override bool IsComplete()
    {
        bool completed;
        if (_isComplete)
        {
            completed = true;
        }
        else
        {
            completed = false;
        }
        return completed;
    }

    public override string GetStringRepresentation()
    {
        string text;
        text = $"SimpleGoal~{_shortName}~{_description}~{_points}~{_isComplete}";
        return text;
    }

    public void SetCompletion(bool completion)
    {
        _isComplete = completion;
    }
}