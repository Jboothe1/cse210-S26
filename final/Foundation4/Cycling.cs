using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Cycling class inherits from the Activity class and stores the speed
        for a cycling activity. It overrides the distance, speed, pace, and summary
        methods for the Polymorphism final project activity.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

public class Cycling : Activity
{
    //////////// Static/Class Attributes ///////////////////
    // No static attributes are needed for this class.

    //////////// Static/Class Methods ///////////////////
    // No static methods are needed for this class.

    //////////// Instance Attributes ///////////////////
    private double _jlbSpeed;

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public Cycling(DateTime jlbDate, int jlbDuration, double jlbSpeed)
        : base(jlbDate, jlbDuration)
    {
        _jlbSpeed = jlbSpeed;
    }

    /////////// Process State Functions /////////////////
    public override double JlbGetSpeed()
    {
        return _jlbSpeed;
    }

    public override double JlbGetDistance()
    {
        return _jlbSpeed * base.JlbGetDuration() / 60;
    }

    public override double JlbGetPace()
    {
        return 60 / _jlbSpeed;
    }

    ////////// Output Functions ///////////////////////
    public override string JlbGetSummary()
    {
        return $"{base.JlbGetSummary()} - Cycling - Distance: {JlbGetDistance():F1} km, Speed: {_jlbSpeed:F1} kph, Pace: {JlbGetPace():F2} min per km";
    }

    public string JlbToString()
    {
        return JlbGetSummary();
    }
}