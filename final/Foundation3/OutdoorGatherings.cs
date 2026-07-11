using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This OutdoorGathering class inherits from the Event class and adds location information.
        It is used for the Inheritance final project activity.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

public class OutdoorGathering : Event
{
    //////////// Static/Class Attributes ///////////////////
    // No static attributes are needed for this class.

    //////////// Static/Class Methods ///////////////////
    // No static methods are needed for this class.

    //////////// Instance Attributes ///////////////////
    private string _jlbLocation;

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public OutdoorGathering(string jlbTitle, string jlbDescription, DateTime jlbDate, string jlbTime, string jlbLocation)
        : base(jlbTitle, jlbDescription, jlbDate, jlbTime, "", "")
    {
        _jlbLocation = jlbLocation;
    }

    /////////// Process State Functions /////////////////
    // No extra process functions are needed for this class.

    ////////// Output Functions ///////////////////////
    public override string JlbFullDetails()
    {
        return $"{base.JlbFullDetails()}\nLocation: {_jlbLocation}";
    }

    public string JlbToString()
    {
        return JlbFullDetails();
    }
}