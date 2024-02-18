public abstract class Employee
{
    
// Attributes across all the employees
    protected float _smallFee;
    protected float _surgeryFee;

    public Employee(float smallFee, float surgeryFee)
    {
        _smallFee = smallFee;
        _surgeryFee = surgeryFee;
    }
    public abstract float GetFee(bool check);

}