using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Running class inherits from the Activity class and stores the distance
        for a running activity. It overrides the distance, speed, pace, and summary
        methods for the Polymorphism final project activity.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

public class Running : Activity
{
    //////////// Static/Class Attributes ///////////////////
    // No static attributes are needed for this class.

    //////////// Static/Class Methods ///////////////////
    // No static methods are needed for this class.

    //////////// Instance Attributes ///////////////////
    private double _jlbDistance;

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public Running(DateTime jlbDate, int jlbDuration, double jlbDistance)
        : base(jlbDate, jlbDuration)
    {
        _jlbDistance = jlbDistance;
    }

    /////////// Process State Functions /////////////////
    public override double JlbGetDistance()
    {
        return _jlbDistance;
    }

    public override double JlbGetSpeed()
    {
        return JlbGetDistance() / base.JlbGetDuration() * 60;
    }

    public override double JlbGetPace()
    {
        return 60 / JlbGetSpeed();
    }

    ////////// Output Functions ///////////////////////
    public override string JlbGetSummary()
    {
        return $"{base.JlbGetSummary()} - Running - Distance: {_jlbDistance} km, Speed: {JlbGetSpeed():F1} kph, Pace: {JlbGetPace():F2} min per km";
    }

    public string JlbToString()
    {
        return JlbGetSummary();
    }
}