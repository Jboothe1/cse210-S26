using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Lectures class inherits from the Event class and adds lecture-specific
        information including the speaker and maximum capacity. It is used for the
        Inheritance final project activity.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

public class Lectures : Event
{
    //////////// Static/Class Attributes ///////////////////
    // No static attributes are needed for this class.

    //////////// Static/Class Methods ///////////////////
    // No static methods are needed for this class.

    //////////// Instance Attributes ///////////////////
    private string _jlbSpeaker;
    private int _jlbMaxCapacity;

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public Lectures(string jlbTitle, string jlbDescription, DateTime jlbDate, string jlbTime, string jlbStreet, string jlbCity, string jlbSpeaker, int jlbMaxCapacity)
        : base(jlbTitle, jlbDescription, jlbDate, jlbTime, jlbStreet, jlbCity)
    {
        _jlbSpeaker = jlbSpeaker;
        _jlbMaxCapacity = jlbMaxCapacity;
    }

    /////////// Process State Functions /////////////////
    // No extra process functions are needed for this class.

    ////////// Output Functions ///////////////////////
    public override string JlbFullDetails()
    {
        return $"{base.JlbFullDetails()}\nSpeaker: {_jlbSpeaker}\nCapacity: {_jlbMaxCapacity}";
    }

    public string JlbToString()
    {
        return JlbFullDetails();
    }
}