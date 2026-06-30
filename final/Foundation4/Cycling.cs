public class Cycling: Activity
{
    private double _speed;

     public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }
    public override double getSpeed()
    {
        return _speed;
    }
     public override double getDistance()
    {
        return _speed * base.getDuration() / 60; 
    }

    public override double getPace()
    {
        return 60 / _speed;
    }

    public override string getSummary()
    {
        return $"{base.getSummary()} - Cycling - Distance: {getDistance():F1} km, Speed: {_speed} kph, Pace: {getPace():F2} min per km";
    }
}