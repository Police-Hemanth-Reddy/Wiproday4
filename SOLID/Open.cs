using System;

public class Open
{
    public static void Main()
    {
        ReportGenerator generator = new ReportGenerator();
        ReportSaver saver = new ReportSaver();

        // Generate the report
        string report = generator.GenerateReport();

        IReportFormatter pdfFormatter = new PdfFormatter();
        IReportFormatter excelFormatter = new ExcelFormatter();

        // Save the formatted reports
        saver.SaveReport(pdfFormatter.FormatReport(report));  
        saver.SaveReport(excelFormatter.FormatReport(report));  
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

// 2️⃣ ReportSaver Class (Responsible for saving reports)
public class ReportSaver
{
    public void SaveReport(string report)
    {
        // Logic to save the report
        Console.WriteLine("Saving report: " + report);
    }
}

public interface IReportFormatter
{
    string FormatReport(string report); 
}

public class PdfFormatter : IReportFormatter
{
    public string FormatReport(string report)
    {
        return $"[PDF Report] {report}";
    }
}

public class ExcelFormatter : IReportFormatter
{
    public string FormatReport(string report)
    {
        return $"[Excel Report] {report}";
    }
}
