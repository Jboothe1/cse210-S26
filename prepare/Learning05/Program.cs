using System;
using System.Collections.Generic;

/* 

    Name: Josh Boothe
    Class: CSE 210
    Description:
        This program demonstrates polymorphism by storing different
        shape objects in one list and calling the same area method
        on each object.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. CSE 210 Polymorphism Learning Activity
        3. ChatGPT assistance

*/

class Program
{
    //////////// Static/Class Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public

    //////////// Static/Class Methods ///////////////////
    /// Methods Permission Order: private, protected, public

    static void Main(string[] jlbArgs)
    {
        List<JlbShape> jlbShapes = new List<JlbShape>();

        JlbSquare jlbSquare = new JlbSquare("Red", 5);
        JlbRectangle jlbRectangle = new JlbRectangle("Blue", 4, 6);
        JlbCircle jlbCircle = new JlbCircle("Green", 3);

        jlbShapes.Add(jlbSquare);
        jlbShapes.Add(jlbRectangle);
        jlbShapes.Add(jlbCircle);

        foreach (JlbShape jlbShape in jlbShapes)
        {
            Console.WriteLine($"Color: {jlbShape.GetJlbColor()}");
            Console.WriteLine($"Area: {jlbShape.GetJlbArea():F2}");
            Console.WriteLine();
        }
    }

    //////////// Instance Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public

    //////////// Constructors ///////////////////

    //////////// Instance Methods ///////////////////
}