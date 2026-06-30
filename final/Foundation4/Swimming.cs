public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double getDistance()
    {
        return _laps * 50 / 1000; 
    }

    public override double getSpeed()
    {
        return getDistance() / base.getDuration() * 60;
    }

    public override double getPace()
    {
        return base.getDuration() / getDistance();
    }

    public override string getSummary()
    {
        return $"{base.getSummary()} - Swimming - Distance: {getDistance():F1} km, Speed: {getSpeed():F1} kph, Pace: {getPace():F2} min per km";
    }
}