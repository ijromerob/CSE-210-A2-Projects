public class Doctor:Employee
{
    public Doctor(float smallFee, float surgeryFee, string name):base(smallFee,surgeryFee,name)
    {
        _smallFee = smallFee;
        _surgeryFee = surgeryFee;
        _name = name;
    }

    public override string Display()
    {   
        string display = $"Dr. {_name} Fee: ${GetFee()}";
        return display;
    }
}