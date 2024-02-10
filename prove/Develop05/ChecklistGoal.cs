public class ChecklistGoal:Goal
{
    //Attributes
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus):base(name,description,points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {   
        int points = 0;
        if (_amountCompleted < _target)
        {
            _amountCompleted += 1;
            points += _points;
            if (_amountCompleted == _target)
            {
                points += _bonus;
            }
        }
        return points;
    }

    public override bool IsComplete()
    {
        bool completed;
        if (_amountCompleted >= _target)
        {
            completed = true;
        }
        else
        {
            completed = false;
        }
        return completed;
    }

    public override string GetDetailsString()
    {
        string text;
        if (IsComplete())
        {
            text = $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            text = $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        return text;
    }
    public override string GetStringRepresentation()
    {
        string text;
        text = $"ChecklistGoal~{_shortName}~{_description}~{_points}~{_bonus}~{_target}~{_amountCompleted}";
        return text;
    }

    public void SetAttempts(int attempts)
    {
        _amountCompleted = attempts;
    }
}