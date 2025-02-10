using System;

public class Program
{
    public static void Main()
    {
        ReportGenerator generator = new ReportGenerator();
        ReportSaver saver = new ReportSaver();

        string report = generator.GenerateReport();

        saver.SaveReport(report);
    }
}

public class ReportGenerator
{
    public string GenerateReport()
    {
        // Logic to generate the report
        Console.WriteLine("Generating report...");
        return "Report Data";  
    }
}

public class ReportSaver
{
    public void SaveReport(string report)
    {
        // Logic to save the report
        Console.WriteLine("Saving report: " + report);
    }
}
