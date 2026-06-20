using System;

/* 

    Name: Josh Boothe
    Class: CSE 210
    Description:
        This is the base class for all shapes. It stores the color
        and provides a virtual area method for derived classes to override.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. CSE 210 Polymorphism Learning Activity
        3. ChatGPT assistance

*/

public class JlbShape
{
    //////////// Static/Class Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public

    //////////// Static/Class Methods ///////////////////
    /// Methods Permission Order: private, protected, public

    //////////// Instance Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public

    private string _jlbColor;

    //////////// Constructors ///////////////////

    public JlbShape(string jlbColor)
    {
        _jlbColor = jlbColor;
    }

    //////////// Instance Methods ///////////////////

    public string GetJlbColor()
    {
        return _jlbColor;
    }

    public void SetJlbColor(string jlbColor)
    {
        _jlbColor = jlbColor;
    }

    public virtual double GetJlbArea()
    {
        return 0;
    }
}