public class Fraction
{
    private int _jlbTop;
    private int _jlbBottom;

    public Fraction()
    {
        _jlbTop = 1;
        _jlbBottom = 1;
    }

    public Fraction(int jlbTop)
    {
        _jlbTop = jlbTop;
        _jlbBottom = 1;
    }

    public Fraction(int jlbTop, int jlbBottom)
    {
        _jlbTop = jlbTop;
        _jlbBottom = jlbBottom;
    }

    public int jlbGetTop()
    {
        return _jlbTop;
    }

    public void jlbSetTop(int jlbTop)
    {
        _jlbTop = jlbTop;
    }

    public int jlbGetBottom()
    {
        return _jlbBottom;
    }

    public void jlbSetBottom(int jlbBottom)
    {
        _jlbBottom = jlbBottom;
    }

    public string jlbGetFractionString()
    {
        return $"{_jlbTop}/{_jlbBottom}";
    }

    public double jlbGetDecimalValue()
    {
        return (double)_jlbTop / _jlbBottom;
    }
}