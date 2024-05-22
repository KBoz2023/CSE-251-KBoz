using System;
using System.Security;

public class Job{
    // Attributes:
    // * company : string
    // * job title: string
    // *start year: string
    // *end year: string
    
    // Behaviors:
    // *
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;
    
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    
}