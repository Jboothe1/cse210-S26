public class Lectures: Event
{
    private string _speaker;
    private int _maxCapacity;

     public Lectures(string title, string description, DateTime date, string time, string street, string city, string speaker, int maxcapacity)
        : base(title, description, date, time, street, city)
    {
        _speaker = speaker;
        _maxCapacity = maxcapacity;
    }
    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nSpeaker: {_speaker}\nCapacity: {_maxCapacity}";
    }


}