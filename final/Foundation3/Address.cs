public class Address
{
    private string _street;
    private string _city;
    public Address(string street, string city){
        _street = street;
        _city = city;

    }
    public string GetAddressDetails()
    {
        return$"{_street}, {_city}";
    }
}