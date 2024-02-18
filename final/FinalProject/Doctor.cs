public class Doctor:Employee
{
    public Doctor(float smallFee, float surgeryFee):base(smallFee,surgeryFee)
    {
        _smallFee = smallFee;
        _surgeryFee = surgeryFee;
    }
    
    
    public override float GetFee(bool check)
    {
        if (check)
        {
            return _smallFee * 2;
        }
        else
        {
            return _surgeryFee * 5;
        }
    }
}