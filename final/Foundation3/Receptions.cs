using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Reception class inherits from the Event class and adds RSVP information.
        It is used for the Inheritance final project activity.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

public class Reception : Event
{
    //////////// Static/Class Attributes ///////////////////
    // No static attributes are needed for this class.

    //////////// Static/Class Methods ///////////////////
    // No static methods are needed for this class.

    //////////// Instance Attributes ///////////////////
    private string _jlbRsvpEmail;

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public Reception(string jlbTitle, string jlbDescription, DateTime jlbDate, string jlbTime, string jlbStreet, string jlbCity, string jlbRsvpEmail)
        : base(jlbTitle, jlbDescription, jlbDate, jlbTime, jlbStreet, jlbCity)
    {
        _jlbRsvpEmail = jlbRsvpEmail;
    }

    /////////// Process State Functions /////////////////
    // No extra process functions are needed for this class.

    ////////// Output Functions ///////////////////////
    public override string JlbFullDetails()
    {
        return $"{base.JlbFullDetails()}\nRSVP Email: {_jlbRsvpEmail}";
    }

    public string JlbToString()
    {
        return JlbFullDetails();
    }
}