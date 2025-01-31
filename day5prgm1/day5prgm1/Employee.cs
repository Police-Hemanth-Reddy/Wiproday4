using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5prgm1
{
    internal interface Employee
    {
        void basicdetails();
        void salarydetails();
    }
    interface Interface2
    {
        void meeting();
    }
    class PermanentEmployee : Employee,Interface2
    {
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public decimal salary { get; set; }
        public void basicdetails()
        {
            Console.WriteLine(emp_id + " " + emp_name);
        }
        public void salarydetails()
        {
            Console.WriteLine(salary);
        }
        public void meeting()
        {
            Console.WriteLine("attended meeting");
        }
    }
}
