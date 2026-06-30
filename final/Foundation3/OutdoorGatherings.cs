public class OutdoorGathering : Event
{
    public OutdoorGathering(string title, string description, DateTime date, string time, string location)
        : base(title, description, date, time, "", "")
    {
        Location = location;
    }

    public string Location { get; }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nLocation: {Location}";
    }
}