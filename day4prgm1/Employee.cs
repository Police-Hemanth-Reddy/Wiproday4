using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4prgm1
{
    internal class Employee//base class
    {
       
            public int emp_id { get; set; }
        public string emp_name { get; set; }
        public virtual void display()//base give virtual not a mandatory
        {
            Console.WriteLine(emp_id + " " + emp_name);
        }
    }    
}
