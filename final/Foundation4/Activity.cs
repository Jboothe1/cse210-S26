using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Activity class is the base class for the Polymorphism final project activity.
        It stores the shared date and duration information for all activities and defines
        virtual methods for distance, speed, pace, and summary.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

public class Activity
{
    //////////// Static/Class Attributes ///////////////////
    // No static attributes are needed for this class.

    //////////// Static/Class Methods ///////////////////
    // No static methods are needed for this class.

    //////////// Instance Attributes ///////////////////
    private DateTime _jlbDate;
    private int _jlbDuration;

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public Activity(DateTime jlbDate, int jlbDuration)
    {
        _jlbDate = jlbDate;
        _jlbDuration = jlbDuration;
    }

    /////////// Process State Functions /////////////////
    public int JlbGetDuration()
    {
        return _jlbDuration;
    }

    public virtual double JlbGetDistance()
    {
        return 0;
    }

    public virtual double JlbGetSpeed()
    {
        return 0;
    }

    public virtual double JlbGetPace()
    {
        return 0;
    }

    ////////// Output Functions ///////////////////////
    public virtual string JlbGetSummary()
    {
        return $"{_jlbDate.ToShortDateString()} ({_jlbDuration} min)";
    }

    public string JlbToString()
    {
        return JlbGetSummary();
    }
}