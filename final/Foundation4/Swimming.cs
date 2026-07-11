using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Swimming class inherits from the Activity class and stores the number
        of laps for a swimming activity. It overrides the distance, speed, pace,
        and summary methods for the Polymorphism final project activity.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

public class Swimming : Activity
{
    //////////// Static/Class Attributes ///////////////////
    // No static attributes are needed for this class.

    //////////// Static/Class Methods ///////////////////
    // No static methods are needed for this class.

    //////////// Instance Attributes ///////////////////
    private int _jlbLaps;

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public Swimming(DateTime jlbDate, int jlbDuration, int jlbLaps)
        : base(jlbDate, jlbDuration)
    {
        _jlbLaps = jlbLaps;
    }

    /////////// Process State Functions /////////////////
    public override double JlbGetDistance()
    {
        return _jlbLaps * 50.0 / 1000;
    }

    public override double JlbGetSpeed()
    {
        return JlbGetDistance() / base.JlbGetDuration() * 60;
    }

    public override double JlbGetPace()
    {
        return base.JlbGetDuration() / JlbGetDistance();
    }

    ////////// Output Functions ///////////////////////
    public override string JlbGetSummary()
    {
        return $"{base.JlbGetSummary()} - Swimming - Distance: {JlbGetDistance():F1} km, Speed: {JlbGetSpeed():F1} kph, Pace: {JlbGetPace():F2} min per km";
    }

    public string JlbToString()
    {
        return JlbGetSummary();
    }
}