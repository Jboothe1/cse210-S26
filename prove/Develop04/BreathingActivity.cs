using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void JlbRun()
    {
        JlbDisplayStartingMessage();

        DateTime jlbStartTime = DateTime.Now;
        DateTime jlbEndTime = jlbStartTime.AddSeconds(JlbGetDuration());

        while (DateTime.Now < jlbEndTime)
        {
            Console.Write("Breathe in... ");
            JlbShowCountdown(4);
            Console.WriteLine();

            if (DateTime.Now >= jlbEndTime)
            {
                break;
            }

            Console.Write("Breathe out... ");
            JlbShowCountdown(6);
            Console.WriteLine();
        }

        JlbDisplayEndingMessage();
    }
}