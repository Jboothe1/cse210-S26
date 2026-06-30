public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, string time, string street, string city, string rsvpEmail)
        : base(title, description, date, time, street, city)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nRSVP Email: {_rsvpEmail}";
    }
}
