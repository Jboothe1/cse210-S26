public class SimpleGoal : Goal
{
    private bool _jlbIsComplete;

    public SimpleGoal(string jlbShortName, string jlbDescription, int jlbPoints)
        : base(jlbShortName, jlbDescription, jlbPoints)
    {
        _jlbIsComplete = false;
    }

    public SimpleGoal(string jlbShortName, string jlbDescription, int jlbPoints, bool jlbIsComplete)
        : base(jlbShortName, jlbDescription, jlbPoints)
    {
        _jlbIsComplete = jlbIsComplete;
    }

    public override int JlbRecordEvent()
    {
        if (!_jlbIsComplete)
        {
            _jlbIsComplete = true;
            return JlbGetPoints();
        }

        return 0;
    }

    public override bool JlbIsComplete()
    {
        return _jlbIsComplete;
    }

    public override string JlbGetDetailsString()
    {
        string jlbCheckbox = " ";

        if (_jlbIsComplete)
        {
            jlbCheckbox = "X";
        }

        return $"[{jlbCheckbox}] {JlbGetShortName()} ({JlbGetDescription()})";
    }

    public override string JlbGetStringRepresentation()
    {
        return $"SimpleGoal:{JlbGetShortName()}|{JlbGetDescription()}|{JlbGetPoints()}|{_jlbIsComplete}";
    }
}