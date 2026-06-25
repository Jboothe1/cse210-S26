public class ChecklistGoal : Goal
{
    private int _jlbAmountCompleted;
    private int _jlbTargetCount;
    private int _jlbBonusPoints;

    public ChecklistGoal(string jlbShortName, string jlbDescription, int jlbPoints, int jlbTargetCount, int jlbBonusPoints)
        : base(jlbShortName, jlbDescription, jlbPoints)
    {
        _jlbAmountCompleted = 0;
        _jlbTargetCount = jlbTargetCount;
        _jlbBonusPoints = jlbBonusPoints;
    }

    public ChecklistGoal(string jlbShortName, string jlbDescription, int jlbPoints, int jlbTargetCount, int jlbBonusPoints, int jlbAmountCompleted)
        : base(jlbShortName, jlbDescription, jlbPoints)
    {
        _jlbAmountCompleted = jlbAmountCompleted;
        _jlbTargetCount = jlbTargetCount;
        _jlbBonusPoints = jlbBonusPoints;
    }

    public override int JlbRecordEvent()
    {
        if (!JlbIsComplete())
        {
            _jlbAmountCompleted++;

            int jlbPointsEarned = JlbGetPoints();

            if (JlbIsComplete())
            {
                jlbPointsEarned += _jlbBonusPoints;
            }

            return jlbPointsEarned;
        }

        return 0;
    }

    public override bool JlbIsComplete()
    {
        return _jlbAmountCompleted >= _jlbTargetCount;
    }

    public override string JlbGetDetailsString()
    {
        string jlbCheckbox = " ";

        if (JlbIsComplete())
        {
            jlbCheckbox = "X";
        }

        return $"[{jlbCheckbox}] {JlbGetShortName()} ({JlbGetDescription()}) -- Currently completed: {_jlbAmountCompleted}/{_jlbTargetCount}";
    }

    public override string JlbGetStringRepresentation()
    {
        return $"ChecklistGoal:{JlbGetShortName()}|{JlbGetDescription()}|{JlbGetPoints()}|{_jlbTargetCount}|{_jlbBonusPoints}|{_jlbAmountCompleted}";
    }
}