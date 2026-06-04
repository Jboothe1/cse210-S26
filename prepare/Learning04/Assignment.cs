using System;

/*
    Name: Josh Boothe
    Class: CSE 210
    Description:
        Base class for homework assignments. Stores the student's name
        and the assignment topic.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
*/

class Assignment
{
    //////////// Instance Attributes ///////////////////

    private string _jlbStudentName;
    private string _jlbTopic;

    /////////// Input Functions ////////////////////////

    public Assignment(string jlbStudentName, string jlbTopic)
    {
        _jlbStudentName = jlbStudentName;
        _jlbTopic = jlbTopic;
    }

    ////////// Output Functions ///////////////////////

    public string jlbGetSummary()
    {
        return $"{_jlbStudentName} - {_jlbTopic}";
    }

    public string jlbGetStudentName()
    {
        return _jlbStudentName;
    }
}