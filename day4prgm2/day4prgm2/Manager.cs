using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4prgm2
{
    internal class Manager:Department
    {
        public string Managername { get; set; }
        public Manager(int emp_id, string emp_name, string dept_name, int salary,string Managername) : base(emp_id, emp_name, dept_name, salary)
        {
            this.Managername = Managername;
        }
        public override void display()//override as it is a child class
        {
            base.display();//goes to base class of Department
            Console.WriteLine("managername" + Managername);
        }
    }
}
