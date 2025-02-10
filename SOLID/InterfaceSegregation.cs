using System;

public class InterfaceSegregation
{
    public static void Main()
    {

        IGenerateReport pdfReport = new PdfReport();
        IGenerateReport excelReport = new ExcelReport();

        Console.WriteLine(pdfReport.GenerateReport());
        Console.WriteLine(excelReport.GenerateReport());

        IReportSaver reportSaver = new ReportSaver();
        reportSaver.SaveReport(pdfReport.GenerateReport());
    }
}

public interface IGenerateReport
{
    string GenerateReport();  // Method to generate the report
}

public interface IReportSaver
{
    void SaveReport(string report);  // Method to save the report
}

public interface IReportPrinter
{
    void PrintReport(string report);  // Method to print the report
}

public class PdfReport : IGenerateReport
{
    public string GenerateReport()
    {
        return "Generating PDF report...";
    }
}

public class ExcelReport : IGenerateReport
{
    public string GenerateReport()
    {
        return "Generating Excel report...";
    }
}

public class ReportSaver : IReportSaver
{
    public void SaveReport(string report)
    {
        Console.WriteLine("Saving report: " + report);
    }
}

public class ReportPrinter : IReportPrinter
{
    public void PrintReport(string report)
    {
        Console.WriteLine("Printing report: " + report);
    }
}
