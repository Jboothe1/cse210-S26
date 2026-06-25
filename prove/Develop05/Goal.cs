public abstract class Goal
{
    private string _jlbShortName;
    private string _jlbDescription;
    private int _jlbPoints;

    public Goal(string jlbShortName, string jlbDescription, int jlbPoints)
    {
        _jlbShortName = jlbShortName;
        _jlbDescription = jlbDescription;
        _jlbPoints = jlbPoints;
    }

    public string JlbGetShortName()
    {
        return _jlbShortName;
    }

    public string JlbGetDescription()
    {
        return _jlbDescription;
    }

    public int JlbGetPoints()
    {
        return _jlbPoints;
    }

    public abstract int JlbRecordEvent();

    public abstract bool JlbIsComplete();

    public abstract string JlbGetDetailsString();

    public abstract string JlbGetStringRepresentation();
}