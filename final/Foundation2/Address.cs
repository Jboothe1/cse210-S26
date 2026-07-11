using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Address class stores a street address, city, state or province, and country.
        It can determine whether the address is in the USA and return the full address details.

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
    private string _jlbStateOrProvince;
    private string _jlbCountry;

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public Address(string jlbStreet, string jlbCity, string jlbStateOrProvince, string jlbCountry)
    {
        _jlbStreet = jlbStreet;
        _jlbCity = jlbCity;
        _jlbStateOrProvince = jlbStateOrProvince;
        _jlbCountry = jlbCountry;
    }

    /////////// Process State Functions /////////////////
    public bool JlbIsUSA()
    {
        return _jlbCountry.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    ////////// Output Functions ///////////////////////
    public string JlbGetAddressDetails()
    {
        return $"{_jlbStreet}, {_jlbCity}, {_jlbStateOrProvince}, {_jlbCountry}";
    }

    public string JlbToString()
    {
        return JlbGetAddressDetails();
    }
}