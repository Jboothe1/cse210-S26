using System;

class Program
{
    static void Main(string[] jlb_args)
    {
        Job jlb_job1 = new Job();
        jlb_job1._jlb_jobTitle = "Cowboy";
        jlb_job1._jlb_company = "The wild west";
        jlb_job1._jlb_startYear = 1880;
        jlb_job1._jlb_endYear = 1891;

        Job jlb_job2 = new Job();
        jlb_job2._jlb_jobTitle = "Sheriff";
        jlb_job2._jlb_company = "Town of Amarillo";
        jlb_job2._jlb_startYear = 1891;
        jlb_job2._jlb_endYear = 1894;

        Resume jlb_myResume = new Resume();
        jlb_myResume._jlb_name = "Jesse Jamison";

        jlb_myResume._jlb_jobs.Add(jlb_job1);
        jlb_myResume._jlb_jobs.Add(jlb_job2);

        jlb_myResume.jlb_Display();
    }
}