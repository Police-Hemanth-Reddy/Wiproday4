using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4prgm2
{
    internal class Employee
    {
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public Employee(int emp_id, string emp_name)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
        }
        public virtual void display()
        {
            Console.WriteLine(emp_id + " " + emp_name);
        }
    }
}
