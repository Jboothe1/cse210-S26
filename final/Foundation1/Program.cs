using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Program class creates several Video objects, adds comments to each video,
        and displays the video information and comments for the Abstraction final project activity.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
        3. Previous CSE 210 project structure
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Input
            // No user input is required for this project.

        // Process
            // Create Video class instances and add Comment information.

        // Output
            // Display each Video object and its comments.

        JlbRunVideoProgram();
    }

    // Project Input functions that call Support Functions
    // No input functions are needed for this program because the assignment allows sample data to be created in Program.cs.

    // Project Process functions that call Class
    public static void JlbRunVideoProgram()
    {
        Video jlbFirstVideo = new Video("Internet Historian", "Ever Given, Ever Taken Away", 16);
        jlbFirstVideo.JlbAddComment("Doug", "Great video!");
        jlbFirstVideo.JlbAddComment("Gus Gus", "Very entertaining");

        Video jlbSecondVideo = new Video("The Strokes", "The Strokes-You Only Live Once (Official HD Video)", 20);
        jlbSecondVideo.JlbAddComment("Nacho", "Awesome");
        jlbSecondVideo.JlbAddComment("Timmy", "Peak music");

        Video jlbThirdVideo = new Video("General Conference of The Church of Jesus Christ", "We Can Do Better and Be Better", 87);
        jlbThirdVideo.JlbAddComment("Shrek", "Loved it! <3");
        jlbThirdVideo.JlbAddComment("Darley Havidson", "Amazing");

        // Output
        JlbDisplayVideo(jlbFirstVideo);
        JlbDisplayVideo(jlbSecondVideo);
        JlbDisplayVideo(jlbThirdVideo);
    }

    // Project Output functions that call Support Functions
    public static void JlbDisplayVideo(Video jlbVideo)
    {
        jlbVideo.JlbDisplayVideo();
    }

    public static void JlbPrint(string jlbText)
    {
        Console.WriteLine(jlbText);
    }
}