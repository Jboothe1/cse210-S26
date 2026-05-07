public class Job
{
    public string _jlb_company;
    public string _jlb_jobTitle;
    public int _jlb_startYear;
    public int _jlb_endYear;

    public void jlb_Display()
    {
        Console.WriteLine($"{_jlb_jobTitle} ({_jlb_company}) {_jlb_startYear}-{_jlb_endYear}");
    }
}