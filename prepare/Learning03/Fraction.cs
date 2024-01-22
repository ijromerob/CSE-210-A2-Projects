public class Fraction
{
    // attributes for the fractions
    private int _top;
    private int _bottom;

    // constructors
    // Since I am creating a fraction constructor receiving arguments then 
    // I need to create one that receives nothing

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
       string fraction =  _top + "/" +_bottom;
       return fraction;
    }
    public double GetDecimalValue()
    {
        double decimal_val = (double)_top/(double)_bottom;
        return decimal_val;
    }
}