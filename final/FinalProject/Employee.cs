public abstract class Employee
{
    
// Attributes across all the employees
    protected string _name;

    protected float _smallFee;
    protected float _surgeryFee;
    protected bool _isSmall;

    public Employee(float smallFee, float surgeryFee, string name)
    {
        _smallFee = smallFee;
        _surgeryFee = surgeryFee;
        // as a default it sets the small fee
        _isSmall = true;
        _name = name;

    }
    public float GetFee()
    {
        if (_isSmall)
        {
            return _smallFee;
        }
        else
        {
            return _surgeryFee;
        }
    }

    public void ModifyFee(bool feeChange)
    {
        _isSmall = feeChange;
    }

    public abstract string Display();

}