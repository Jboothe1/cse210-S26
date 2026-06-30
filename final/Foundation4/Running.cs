public class Running : Activity
{
    private double _distance;

     public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }
    public override double getDistance(){
        return _distance;
    }

    public override double getSpeed()
    {
        return getDistance()  / base.getDuration() * 60; 
    }
    public override double getPace(){
        return 60/getSpeed();
    }
    public override string getSummary()
    {
        return $"{base.getSummary()} - Running - Distance: {_distance} km, Speed: {getSpeed():F1} kph, Pace: {getPace():F2} min per km";
    }
}