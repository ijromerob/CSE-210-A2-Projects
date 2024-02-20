public abstract class Area
{
    // Atribute will be the area name of the hospital that can be used across the building
    protected string _areaName;

    //Cost of use will be one method that will be different for each class
    public abstract float CostOfUse();

    public string DisplayAreaCost()
    {
        string AreaCost = $"{_areaName} Cost of use: ${CostOfUse()}";
        return AreaCost;
    }
}