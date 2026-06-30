using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Video firstVideo = new Video("Internet Historian", "Ever Given, Ever Taken Away", 16);
        firstVideo.AddComment("Doug", "Great video!");
        firstVideo.AddComment("Gus Gus", "Very entertaining");
        firstVideo.DisplayVideo();

        Video secondVideo = new Video("The Strokes", "The Strokes-You Only Live Once (Official HD Video)", 20);
        secondVideo.AddComment("Nacho", "Awesome");
        secondVideo.AddComment("Timmy", "Peak music");
        secondVideo.DisplayVideo();

        Video thirdVideo = new Video("General Conference of The Church of Jesus Christ", "We Can Do Better and Be Better", 87);
        thirdVideo.AddComment("Shrek", "Loved it! <3");
        thirdVideo.AddComment("Darley Havidson", "Amazing");
        thirdVideo.DisplayVideo();
        
    }
}