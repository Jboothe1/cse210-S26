using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        Cycling cyclingActivity = new Cycling(new DateTime(2022, 11, 3), 30, 20.0); 
        Swimming swimmingActivity = new Swimming(new DateTime(2022, 11, 3), 10, 30);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);
        
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.getSummary());
        }
    }
}