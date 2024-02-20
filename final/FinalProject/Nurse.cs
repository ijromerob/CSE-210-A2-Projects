public class Nurse: Employee
{
    // Attributes
    public Nurse(float smallFee, float surgeryFee, string name):base(smallFee,surgeryFee, name)
    {
        _smallFee = smallFee;
        _surgeryFee = surgeryFee;
        _name = name;
    }
    public override string Display()
    {
        string display = $"Nurse: {_name} Fee: ${GetFee()}";
        return display;
    }
}