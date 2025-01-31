namespace day5prgm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the emp details:");
            PermanentEmployee p = new PermanentEmployee() { emp_id = 111, emp_name = "hemanth", salary = 2000 };
            p.basicdetails();
            p.salarydetails();
            p.meeting();
        }
    }
}