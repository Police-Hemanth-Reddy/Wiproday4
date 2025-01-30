using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4prgm1
{
    internal class Department:Employee
    {
        public string dept_name { get; set; }
        public int salary {  get; set; } 
        public override void display()
        {
            base.display();//goes to base class Employee
            Console.WriteLine(dept_name + " " + salary);
        }
    }
}
