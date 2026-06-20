using System;

/* 

    Name: Josh Boothe
    Class: CSE 210
    Description:
        This class represents a rectangle. It inherits from JlbShape
        and overrides the area method.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. CSE 210 Polymorphism Learning Activity
        3. ChatGPT assistance

*/

public class JlbRectangle : JlbShape
{
    //////////// Static/Class Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public

    //////////// Static/Class Methods ///////////////////
    /// Methods Permission Order: private, protected, public

    //////////// Instance Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public

    private double _jlbLength;
    private double _jlbWidth;

    //////////// Constructors ///////////////////

    public JlbRectangle(string jlbColor, double jlbLength, double jlbWidth) : base(jlbColor)
    {
        _jlbLength = jlbLength;
        _jlbWidth = jlbWidth;
    }

    //////////// Instance Methods ///////////////////

    public override double GetJlbArea()
    {
        return _jlbLength * _jlbWidth;
    }
}