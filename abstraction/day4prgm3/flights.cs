using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Flights
    {
        public int flightno { get; set; }
        public string? flightname { get; set; }
        public void flightdetails()
        {
            Console.WriteLine(flightno + " " + flightname);
        }
        public abstract void faredetails();
    }

    class Flightfare : Flights
    {
        public int basicfare {  get; private set; } //as it is private it cant be initilzed outside this class
        public int durationhrs {  get; set; }   
        public string des {  get; set; }    
        public override void faredetails()
        {
            if (durationhrs > 4)
            {
                basicfare = 4000;
            }
            else
            {
                basicfare = 2000;
            }
            if (des.ToLower().Equals("international")){
                basicfare += 5000;
            }
            Console.WriteLine($"basicfare:{basicfare}");
        }
    }

}
