using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Comment class stores the name of a commenter and the text of their comment.
        It is used by the Video class for the Abstraction final project activity.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

public class Comment
{
    //////////// Static/Class Attributes ///////////////////
    // No static attributes are needed for this class.

    //////////// Static/Class Methods ///////////////////
    // No static methods are needed for this class.

    //////////// Instance Attributes ///////////////////
    private string _jlbName;
    private string _jlbText;

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public Comment(string jlbName, string jlbText)
    {
        _jlbName = jlbName;
        _jlbText = jlbText;
    }

    /////////// Process State Functions /////////////////
    // No process functions are needed because this class only stores comment information.

    ////////// Output Functions ///////////////////////
    public void JlbDisplayComment()
    {
        Console.WriteLine($"{_jlbName}: {_jlbText}");
    }

    public string JlbToString()
    {
        return $"{_jlbName}: {_jlbText}";
    }
}