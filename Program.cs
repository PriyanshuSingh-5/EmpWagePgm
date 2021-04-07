using System;

namespace EmpWage1
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int EMP_RATE_PER_HR = 20;
            int EMP_TOTAL_WORKING_DAYS_PER_MONTH = 20;

            //LOCAL VARIABLES
            int empHrs = 0;
            int empWage = 0;

            //inbuilt class
            Random random = new Random();
            int employeeCheck = random.Next(0, 4);

            Console.WriteLine("random value" + employeeCheck);

            //Selection statements
            if (employeeCheck == FULL_TIME)
            {
                empHrs = 8;
            }
            else if (employeeCheck == PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            //Computations
            empWage = EMP_RATE_PER_HR * empHrs * EMP_TOTAL_WORKING_DAYS_PER_MONTH;
            Console.WriteLine("Employee wage per MONTH" + empWage);
            Console.Read();
        }
    }
}