using System;

/*
    Name: Josh Boothe
    Class: CSE 210
    Description:
        Derived class for writing homework assignments. Inherits student name
        and topic from the Assignment class.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
*/

class WritingAssignment : Assignment
{
    //////////// Instance Attributes ///////////////////

    private string _jlbTitle;

    /////////// Input Functions ////////////////////////

    public WritingAssignment(
        string jlbStudentName,
        string jlbTopic,
        string jlbTitle
    ) : base(jlbStudentName, jlbTopic)
    {
        _jlbTitle = jlbTitle;
    }

    ////////// Output Functions ///////////////////////

    public string jlbGetWritingInformation()
    {
        return $"{_jlbTitle} by {jlbGetStudentName()}";
    }
}