using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Address class stores the street and city for an event location.
        It is used by the Event class for the Inheritance final project activity.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

public class Address
{
    //////////// Static/Class Attributes ///////////////////
    // No static attributes are needed for this class.

    //////////// Static/Class Methods ///////////////////
    // No static methods are needed for this class.

    //////////// Instance Attributes ///////////////////
    private string _jlbStreet;
    private string _jlbCity;

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public Address(string jlbStreet, string jlbCity)
    {
        _jlbStreet = jlbStreet;
        _jlbCity = jlbCity;
    }

    /////////// Process State Functions /////////////////
    // No process functions are needed because this class only stores address information.

    ////////// Output Functions ///////////////////////
    public string JlbGetAddressDetails()
    {
        return $"{_jlbStreet}, {_jlbCity}";
    }

    public string JlbToString()
    {
        return JlbGetAddressDetails();
    }
}