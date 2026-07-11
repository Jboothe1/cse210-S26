using System;
using System.Collections.Generic;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Video class stores the title, author, length, and comments for a video.
        It is used for the Abstraction final project activity.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

public class Video
{
    //////////// Static/Class Attributes ///////////////////
    // No static attributes are needed for this class.

    //////////// Static/Class Methods ///////////////////
    // No static methods are needed for this class.

    //////////// Instance Attributes ///////////////////
    private string _jlbTitle;
    private string _jlbAuthor;
    private float _jlbLengthOfVideo;
    private List<Comment> _jlbComments = new List<Comment>();

    //////////// Instance Methods ///////////////////

    /////////// Input Functions ////////////////////////
    public Video(string jlbTitle, string jlbAuthor, float jlbLengthOfVideo)
    {
        _jlbTitle = jlbTitle;
        _jlbAuthor = jlbAuthor;
        _jlbLengthOfVideo = jlbLengthOfVideo;
    }

    /////////// Process State Functions /////////////////
    public void JlbAddComment(string jlbName, string jlbText)
    {
        Comment jlbComment = new Comment(jlbName, jlbText);
        _jlbComments.Add(jlbComment);
    }

    public int JlbGetCommentCount()
    {
        return _jlbComments.Count;
    }

    ////////// Output Functions ///////////////////////
    public void JlbDisplayVideo()
    {
        Console.WriteLine($"{_jlbTitle}, {_jlbAuthor}, {_jlbLengthOfVideo}");
        Console.WriteLine($"Number of comments: {JlbGetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (Comment jlbComment in _jlbComments)
        {
            jlbComment.JlbDisplayComment();
        }

        Console.WriteLine();
    }

    public string JlbToString()
    {
        return $"{_jlbTitle}, {_jlbAuthor}, {_jlbLengthOfVideo}";
    }
}