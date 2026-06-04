using System;

/*
    Name: Josh Boothe
    Class: CSE 210
    Description:
        Derived class for math homework assignments. Inherits student name
        and topic from the Assignment class.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
*/

class MathAssignment : Assignment
{
    //////////// Instance Attributes ///////////////////

    private string _jlbTextbookSection;
    private string _jlbProblems;

    /////////// Input Functions ////////////////////////

    public MathAssignment(
        string jlbStudentName,
        string jlbTopic,
        string jlbTextbookSection,
        string jlbProblems
    ) : base(jlbStudentName, jlbTopic)
    {
        _jlbTextbookSection = jlbTextbookSection;
        _jlbProblems = jlbProblems;
    }

    ////////// Output Functions ///////////////////////

    public string jlbGetHomeworkList()
    {
        return $"Section {_jlbTextbookSection} Problems {_jlbProblems}";
    }
}