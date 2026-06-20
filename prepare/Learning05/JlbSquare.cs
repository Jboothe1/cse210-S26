using System;

/* 

    Name: Josh Boothe
    Class: CSE 210
    Description:
        This class represents a square. It inherits from JlbShape
        and overrides the area method.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. CSE 210 Polymorphism Learning Activity
        3. ChatGPT assistance

*/

public class JlbSquare : JlbShape
{
    //////////// Static/Class Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public

    //////////// Static/Class Methods ///////////////////
    /// Methods Permission Order: private, protected, public

    //////////// Instance Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public

    private double _jlbSide;

    //////////// Constructors ///////////////////

    public JlbSquare(string jlbColor, double jlbSide) : base(jlbColor)
    {
        _jlbSide = jlbSide;
    }

    //////////// Instance Methods ///////////////////

    public override double GetJlbArea()
    {
        return _jlbSide * _jlbSide;
    }
}