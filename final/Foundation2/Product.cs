using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Product class stores product information including the product name,
        product ID, price, and quantity. It can return product details and calculate
        the total cost for that product.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

public class Product
{
    //////////// Static/Class Attributes ///////////////////
    // No static attributes are needed for this class.

    //////////// Static/Class Methods ///////////////////
    // No static methods are needed for this class.

    //////////// Instance Attributes ///////////////////
    private string _jlbName;
    private int _jlbProductId;
    private decimal _jlbPrice;
    private int _jlbQuantity;

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public Product(string jlbName, int jlbProductId, decimal jlbPrice, int jlbQuantity)
    {
        _jlbName = jlbName;
        _jlbProductId = jlbProductId;
        _jlbPrice = jlbPrice;
        _jlbQuantity = jlbQuantity;
    }

    /////////// Process State Functions /////////////////
    public decimal JlbProductPrice()
    {
        return _jlbPrice * _jlbQuantity;
    }

    ////////// Output Functions ///////////////////////
    public string JlbGetProductDetails()
    {
        return $"{_jlbName}, {_jlbProductId}, {_jlbPrice}, {_jlbQuantity}";
    }

    public string JlbGetPackingDetails()
    {
        return $"Product Name: {_jlbName}\nProduct ID: {_jlbProductId}";
    }

    public string JlbToString()
    {
        return $"Name: {_jlbName}, Product ID: {_jlbProductId}, Price: {_jlbPrice:C}, Quantity: {_jlbQuantity}";
    }
}