using System;
namespace EmployeeWages
{
    class Program
    {
        public const int Fulltime = 1;
        public const int Parttime = 2;
        public const int Perhour = 20;
        static void Main(string[] args)
        {
            int emphrs = 0;
            int empwages=0;

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
            empwages = emphrs*Perhour;
            Console.WriteLine("Employee Wages: " + empwages);
        }
    }
}
