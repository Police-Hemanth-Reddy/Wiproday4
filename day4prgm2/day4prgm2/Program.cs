using System.Security.Cryptography.X509Certificates;
using day4prgm2;

namespace WiproOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Employee emp = new Employee();
             emp.emp_id = 11;
             emp.emp_name = "test";
             emp.display();

             Department d = new Department();
             d.emp_id = 111;
             d.emp_name = "hemanth";
             d.dept_name = "developer";
             d.salary = 500;
             d.display();

             Manager m = new Manager();
             m.emp_id = 123;
             m.emp_name = "shiva";
             m.dept_name = "it";
             m.salary = 1000;
             m.Managername = "roy";
             m.display();*/
            int id = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            string dname = Console.ReadLine();
            int sal = Convert.ToInt32(Console.ReadLine());
            string mname = Console.ReadLine();
            Manager mgrcon = new Manager(id, name, dname, sal, mname);
            mgrcon.display();



        }
    }
}