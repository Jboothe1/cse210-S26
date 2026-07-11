using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Customer class stores a customer's name and address. It can determine
        whether the customer lives in the USA and return the customer's full details.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

public class Customer
{
    //////////// Static/Class Attributes ///////////////////
    // No static attributes are needed for this class.

    //////////// Static/Class Methods ///////////////////
    // No static methods are needed for this class.

    //////////// Instance Attributes ///////////////////
    private string _jlbName;
    private Address _jlbAddress;

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public Customer(string jlbName, Address jlbAddress)
    {
        _jlbName = jlbName;
        _jlbAddress = jlbAddress;
    }

    /////////// Process State Functions /////////////////
    public bool JlbIsUSA()
    {
        return _jlbAddress.JlbIsUSA();
    }

    ////////// Output Functions ///////////////////////
    public string JlbGetCustomerDetails()
    {
        return $"{_jlbName}: {_jlbAddress.JlbGetAddressDetails()}";
    }

    public string JlbToString()
    {
        return JlbGetCustomerDetails();
    }
}