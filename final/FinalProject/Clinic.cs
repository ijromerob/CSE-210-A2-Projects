public class Clinic:Area
{
    //attributes
    private float _hourlyRate;
    private int _hoursUsed;

    public Clinic (float hourlyRate, int hoursUsed)
    {
        _hourlyRate = hourlyRate;
        _hoursUsed = hoursUsed;
        _areaName = "Clinic";
    }

    public override float CostOfUse()
    {
        float cost;
        cost = _hourlyRate * _hoursUsed;
        return cost;
    }
}