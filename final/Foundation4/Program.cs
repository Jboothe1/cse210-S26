using System;
using System.Collections.Generic;

/* 
    Name: Josh Boothe
    Class: CSE 210
    Description:
        This Program class creates sample exercise activities for the Polymorphism
        final project activity. It stores running, cycling, and swimming activities
        in one list and displays a summary for each activity.

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
            // Create Activity class instances using derived classes.

        // Output
            // Display the summary for each activity.

        JlbRunActivityProgram();
    }

    // Project Input functions that call Support Functions
    // No input functions are needed because the assignment allows sample data to be created in Program.cs.

    // Project Process functions that call Class
    public static void JlbRunActivityProgram()
    {
        List<Activity> jlbActivities = new List<Activity>();

        Running jlbRunningActivity = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        Cycling jlbCyclingActivity = new Cycling(new DateTime(2022, 11, 3), 30, 20.0);
        Swimming jlbSwimmingActivity = new Swimming(new DateTime(2022, 11, 3), 10, 30);

        jlbActivities.Add(jlbRunningActivity);
        jlbActivities.Add(jlbCyclingActivity);
        jlbActivities.Add(jlbSwimmingActivity);

        JlbDisplayActivities(jlbActivities);
    }

    // Project Output functions that call Support Functions
    public static void JlbDisplayActivities(List<Activity> jlbActivities)
    {
        foreach (Activity jlbActivity in jlbActivities)
        {
            JlbPrint(jlbActivity.JlbGetSummary());
        }
    }

    public static void JlbPrint(string jlbText)
    {
        Console.WriteLine(jlbText);
    }
}