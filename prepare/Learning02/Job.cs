//Job1 file created

using System;
using System.Security.AccessControl;

//create public class
public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public Job(string jobTitle, string Company, int startYear, int endYear)
    
    {
        _jobTitle = jobTitle;
        _company = Company;
        _startYear = startYear;
        _endYear = endYear;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        

    }
    

}