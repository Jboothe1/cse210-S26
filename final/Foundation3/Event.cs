using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Event class is the base class for the Inheritance final project activity.
        It stores the shared event information including title, description, date, time,
        and address. It provides standard details, full details, and short description methods.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

public class Event
{
    //////////// Static/Class Attributes ///////////////////
    // No static attributes are needed for this class.

    //////////// Static/Class Methods ///////////////////
    // No static methods are needed for this class.

    //////////// Instance Attributes ///////////////////
    private string _jlbEventTitle;
    private string _jlbDescription;
    private DateTime _jlbDate;
    private string _jlbTime;
    private Address _jlbAddress;

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public Event(string jlbTitle, string jlbDescription, DateTime jlbDate, string jlbTime, string jlbStreet, string jlbCity)
    {
        _jlbEventTitle = jlbTitle;
        _jlbDescription = jlbDescription;
        _jlbDate = jlbDate;
        _jlbTime = jlbTime;
        _jlbAddress = new Address(jlbStreet, jlbCity);
    }

    /////////// Process State Functions /////////////////
    // No extra process functions are needed for this base class.

    ////////// Output Functions ///////////////////////
    public string JlbStandardDetails()
    {
        return $"Event Title: {_jlbEventTitle}\nDescription: {_jlbDescription}\nDate: {_jlbDate.ToString("yyyy-MM-dd")}\nTime: {_jlbTime}\nAddress: {_jlbAddress.JlbGetAddressDetails()}";
    }

    public virtual string JlbFullDetails()
    {
        return JlbStandardDetails();
    }

    public virtual string JlbShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {_jlbEventTitle}\nDate: {_jlbDate.ToString("yyyy-MM-dd")}";
    }

    public string JlbToString()
    {
        return JlbStandardDetails();
    }
}