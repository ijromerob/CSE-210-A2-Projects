public class Nurse: Employee
{
    // Attributes
    public Nurse(float smallFee, float surgeryFee):base(smallFee,surgeryFee)
    {
        _smallFee = smallFee;
        _surgeryFee = surgeryFee;
    }
    // this will check if the which fee will be applied 
    public override float GetFee(bool check)
    {   
        //if true then will have small check
        if (check)
        {
            return _smallFee;
        }
        else
        {
            return _surgeryFee;
        }

    }
}