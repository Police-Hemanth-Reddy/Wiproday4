using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4prgm1
{
    internal class Manager:Department
    {
        public string Managername { get; set; }
        public override void display()//override as it is a child class
        {
            base.display();//goes to base class of Department
            Console.WriteLine("managername" + Managername);
        }
    }
}
