public class SharedRoom:Area
{
    private float _dailyRate;
    private int _daysUsed;

    public SharedRoom(float dailyRate, int daysUsed)
    {
        _dailyRate = dailyRate;
        _daysUsed = daysUsed;
        _areaName = "Shared Room";
    }

    public override float CostOfUse()
    {
        float cost;
        cost = _daysUsed * _dailyRate;
        return cost;
    }
}