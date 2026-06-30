using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lectureEvent = new Lectures("The Problem That Wont Let You Go", "On what principle is the world founded? And on what principle should the world be founded?", DateTime.Now, "02:00", "James Street", "Toronto", "Dr. Jordan Peterson", 1500);

        Reception receptionEvent = new Reception("The Marriage of Figaro", "An Italian event with music", DateTime.Now, "4:00", "Roman Colloseum", "Rome", "RSVP by pigeon");

        OutdoorGathering outdoorEvent = new OutdoorGathering("Tower of Babel Construction", "We gonna get to heaven the alt route", DateTime.Now, "08:00", "Shinar");

        DisplayEventDetails(lectureEvent, "Standard details");
        DisplayEventDetails(lectureEvent, "Full details");
        DisplayEventDetails(lectureEvent, "Short description");

        DisplayEventDetails(receptionEvent, "Standard details");
        DisplayEventDetails(receptionEvent, "Full details");
        DisplayEventDetails(receptionEvent, "Short description");

        DisplayEventDetails(outdoorEvent, "Standard details");
        DisplayEventDetails(outdoorEvent, "Full details");
        DisplayEventDetails(outdoorEvent, "Short description");

        static void DisplayEventDetails(Event evento, string messageType)
    {
        string message;

        switch (messageType)
        {
            case "Standard details":
                message = evento.StandardDetails();
                break;
            case "Full details":
                message = evento.FullDetails();
                break;
            case "Short description":
                message = evento.ShortDescription();
                break;
            default:
                message = "Invalid message type";
                break;
        }

        Console.WriteLine($"Event Type: {evento.GetType().Name}\nMessage Type: {messageType}\nMessage: {message}\n");
    }
    }
}