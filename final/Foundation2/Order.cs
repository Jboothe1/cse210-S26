using System;
using System.Collections.Generic;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Order class stores a customer and a list of products. It can add products,
        calculate the total order cost including shipping, and return packing and shipping labels.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

public class Order
{
    //////////// Static/Class Attributes ///////////////////
    // No static attributes are needed for this class.

    //////////// Static/Class Methods ///////////////////
    // No static methods are needed for this class.

    //////////// Instance Attributes ///////////////////
    private List<Product> _jlbProducts;
    private Customer _jlbCustomer;

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public Order(Customer jlbCustomer)
    {
        _jlbCustomer = jlbCustomer;
        _jlbProducts = new List<Product>();
    }

    /////////// Process State Functions /////////////////
    public void JlbAddProduct(Product jlbProduct)
    {
        _jlbProducts.Add(jlbProduct);
    }

    public decimal JlbCalculateTotalCost()
    {
        decimal jlbTotalProductPrice = 0;

        foreach (Product jlbProduct in _jlbProducts)
        {
            jlbTotalProductPrice += jlbProduct.JlbProductPrice();
        }

        decimal jlbShippingCost = _jlbCustomer.JlbIsUSA() ? 5 : 35;

        return jlbTotalProductPrice + jlbShippingCost;
    }

    ////////// Output Functions ///////////////////////
    public string JlbGetPackingLabel()
    {
        string jlbPackingLabel = $"Packing Label for {_jlbCustomer.JlbGetCustomerDetails()}:\n";

        foreach (Product jlbProduct in _jlbProducts)
        {
            jlbPackingLabel += jlbProduct.JlbGetPackingDetails() + "\n";
        }

        return jlbPackingLabel;
    }

    public string JlbGetShippingLabel()
    {
        return $"Shipping Label for {_jlbCustomer.JlbGetCustomerDetails()}";
    }

    public string JlbToString()
    {
        return $"{JlbGetPackingLabel()}\n{JlbGetShippingLabel()}\nTotal Cost: {JlbCalculateTotalCost():C}";
    }
}