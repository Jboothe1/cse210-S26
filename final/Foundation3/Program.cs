using System;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Program class creates sample events for the Inheritance final project activity.
        It creates a lecture, reception, and outdoor gathering, then displays the standard
        details, full details, and short description for each event.

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
            // Create Event class instances using derived classes.

        // Output
            // Display standard details, full details, and short descriptions.

        JlbRunEventProgram();
    }

    // Project Input functions that call Support Functions
    // No input functions are needed because the assignment allows sample data to be created in Program.cs.

    // Project Process functions that call Class
    public static void JlbRunEventProgram()
    {
        Lectures jlbLectureEvent = new Lectures(
            "The Problem That Wont Let You Go",
            "On what principle is the world founded? And on what principle should the world be founded?",
            DateTime.Now,
            "02:00",
            "James Street",
            "Toronto",
            "Dr. Jordan Peterson",
            1500
        );

        Reception jlbReceptionEvent = new Reception(
            "The Marriage of Figaro",
            "An Italian event with music",
            DateTime.Now,
            "4:00",
            "Roman Colloseum",
            "Rome",
            "RSVP by pigeon"
        );

        OutdoorGathering jlbOutdoorEvent = new OutdoorGathering(
            "Tower of Babel Construction",
            "We gonna get to heaven the alt route",
            DateTime.Now,
            "08:00",
            "Shinar"
        );

        JlbDisplayAllEventDetails(jlbLectureEvent);
        JlbDisplayAllEventDetails(jlbReceptionEvent);
        JlbDisplayAllEventDetails(jlbOutdoorEvent);
    }

    // Project Output functions that call Support Functions
    public static void JlbDisplayAllEventDetails(Event jlbEvent)
    {
        JlbDisplayEventDetails(jlbEvent, "Standard details");
        JlbDisplayEventDetails(jlbEvent, "Full details");
        JlbDisplayEventDetails(jlbEvent, "Short description");
    }

    public static void JlbDisplayEventDetails(Event jlbEvent, string jlbMessageType)
    {
        string jlbMessage;

        switch (jlbMessageType)
        {
            case "Standard details":
                jlbMessage = jlbEvent.JlbStandardDetails();
                break;

            case "Full details":
                jlbMessage = jlbEvent.JlbFullDetails();
                break;

            case "Short description":
                jlbMessage = jlbEvent.JlbShortDescription();
                break;

            default:
                jlbMessage = "Invalid message type";
                break;
        }

        JlbPrint($"Event Type: {jlbEvent.GetType().Name}");
        JlbPrint($"Message Type: {jlbMessageType}");
        JlbPrint($"Message: {jlbMessage}");
        JlbPrint("");
    }

    public static void JlbPrint(string jlbText)
    {
        Console.WriteLine(jlbText);
    }
}