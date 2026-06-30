public class Event
{
    private string _eventTitle;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, DateTime date, string time, string street, string city)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address(street, city);
    }

    public string StandardDetails(){
        return $"Event Title: {_eventTitle}, Description: {_description}, Date: {_date.ToString("yyyy-MM-dd")}, Time: {_time}, Address: {_address.GetAddressDetails()}";
    }

    public virtual string FullDetails(){
        return StandardDetails();
    }
    public virtual string ShortDescription(){
        return $"Type: {GetType().Name}\nTitle: {_eventTitle}\nDate: {_date}";
    }
}