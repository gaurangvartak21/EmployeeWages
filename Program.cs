using System;
namespace EmployeeWages
{
    class Program
    {
        public const int Fulltime = 1;
        public const int Parttime = 2;
        public const int Perhour = 20;
        public const int Workingdays = 20;
        static void Main(string[] args)
        {
            int emphrs = 0;
            int empwages=0;
            int totalwages = 0;

            for (int day = 0; day < Workingdays; day++)
            {
                Random random = new Random();

                int employeestatus = random.Next(0, 3);
                switch (employeestatus)
                {
                    case Fulltime:
                        emphrs = 8;
                        break;
                    case Parttime:
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                empwages = emphrs * Perhour;
                totalwages = empwages * Workingdays;
                Console.WriteLine("Employee Wages: " + empwages);
            }
            Console.WriteLine("Total employee wages are " + totalwages);
        }
    }
}
