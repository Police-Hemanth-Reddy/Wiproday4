using System;

public class Dependancy
{
    public static void Main()
    {
        IGenerateReport pdfReport = new PdfReport();
        IReportSaver reportSaver = new ReportSaver();

        ReportService reportService = new ReportService(pdfReport, reportSaver);

        reportService.GenerateAndSaveReport();
    }
}

public interface IGenerateReport
{
    string GenerateReport();  
}

public interface IReportSaver
{
    void SaveReport(string report);  
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

public class ReportService
{
    private readonly IGenerateReport _reportGenerator;
    private readonly IReportSaver _reportSaver;

    public ReportService(IGenerateReport reportGenerator, IReportSaver reportSaver)
    {
        _reportGenerator = reportGenerator;
        _reportSaver = reportSaver;
    }

    public void GenerateAndSaveReport()
    {
        string report = _reportGenerator.GenerateReport();
        _reportSaver.SaveReport(report);
    }
}
