using System;

public class Liskov
{
    public static void Main()
    {
        Report pdfReport = new PdfReport();
        Report excelReport = new ExcelReport();


        Console.WriteLine(pdfReport.GenerateReport());
        Console.WriteLine(excelReport.GenerateReport());
    }
}

public abstract class Report
{
    public abstract string GenerateReport();
}

public class PdfReport : Report
{
    public override string GenerateReport()
    {
        return "Generating PDF report...";
    }
}

public class ExcelReport : Report
{
    public override string GenerateReport()
    {
        return "Generating Excel report...";
    }
}
