using System;
namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fulltime = 1;
            Random random = new Random();

            int employeestatus = random.Next(0, 2);
            if (employeestatus == Fulltime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
                }
        }
    }
}
