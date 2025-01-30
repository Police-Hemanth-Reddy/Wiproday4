using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4prgm2
{
    internal class Department:Employee
    {
        public string dept_name { get; set; }
        public int salary { get; set; }
        public Department(int emp_id,string emp_name,string dept_name,int salary) : base(emp_id, emp_name)
        {
            this.dept_name = dept_name;
            this.salary = salary;
        }
        public override void display()
        {
            base.display();//goes to base class Employee
            Console.WriteLine(dept_name + " " + salary);
        }
    }
}
