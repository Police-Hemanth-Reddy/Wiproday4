using Abstract;
internal class Program
{
    private static void Main(string[] args)
    {
        Flightfare f = new Flightfare() { flightno = 11, flightname = "airindia", durationhrs = 6, des = "internation" };
        f.flightdetails();
        f.faredetails();
        Flights ff = new Flightfare() { flightno = 12, flightname = "Spicejet", durationhrs = 3,des = "National" };
        ff.flightdetails();
        ff.faredetails();
    }
}