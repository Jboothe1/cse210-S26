using System;
using System.Collections.Generic;

public class Resume
{
    public string _jlb_name;
    public List<Job> _jlb_jobs = new List<Job>();

    public void jlb_Display()
    {
        Console.WriteLine($"Name: {_jlb_name}");
        Console.WriteLine("Jobs:");

        foreach (Job jlb_job in _jlb_jobs)
        {
            jlb_job.jlb_Display();
        }
    }
}