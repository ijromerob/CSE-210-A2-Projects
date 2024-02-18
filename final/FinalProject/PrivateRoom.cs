public class PrivateRoom:Area
{
    private float _dailyRate;
    private int _daysUsed;
    // This method will bring back the cost of using the private room

    public PrivateRoom(float dailyRate, int daysUsed)
    {
        _dailyRate = dailyRate;
        _daysUsed = daysUsed;
        _areaName = "Private Room";
    }

    public override float CostOfUse()
    {
        float cost;
        cost = _daysUsed * _dailyRate;
        return cost;
    }
}