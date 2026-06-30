public class Activity
{
    private DateTime _date;
    private int _duration;

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

        public int getDuration()
    {
        return _duration;
    }

    public virtual double getDistance(){
        return 0;
    }

    public virtual double getSpeed(){
        return 0;
    }

    public virtual double getPace(){
        return 0;
    }

    public virtual string getSummary(){
        return $"{_date.ToShortDateString()} ({_duration} min)";
    }
}