public class Supplies
{
    // Attributes
    private string _name;
    private float _unitaryCost;
    private int _amount;

    public Supplies(string name, float unitaryCost, int amount)
    {
        _name = name;
        _unitaryCost = unitaryCost;
        _amount = amount;
    }
    public string GetName()
    {
        return _name;
    }
    public float GetCost()
    {
        float cost = _unitaryCost * _amount;
        return cost;
    }
}