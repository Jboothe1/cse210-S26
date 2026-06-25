public class EternalGoal : Goal
{
    public EternalGoal(string jlbShortName, string jlbDescription, int jlbPoints)
        : base(jlbShortName, jlbDescription, jlbPoints)
    {
    }

    public override int JlbRecordEvent()
    {
        return JlbGetPoints();
    }

    public override bool JlbIsComplete()
    {
        return false;
    }

    public override string JlbGetDetailsString()
    {
        return $"[ ] {JlbGetShortName()} ({JlbGetDescription()})";
    }

    public override string JlbGetStringRepresentation()
    {
        return $"EternalGoal:{JlbGetShortName()}|{JlbGetDescription()}|{JlbGetPoints()}";
    }
}