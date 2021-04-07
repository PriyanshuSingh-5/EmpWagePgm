using System;

namespace EmpWage1
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            int PRESENT = 1;
            int EMP_RATE_PER_HR = 20;

            //LOCAL VARIABLES
            int empHrs = 0;
            int empWage = 0;

            //inbuilt class
            Random random = new Random();
            int employeeCheck = random.Next(0, 2);

            Console.WriteLine("random value" + employeeCheck);

            //Selection statements
            if(employeeCheck== PRESENT)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            //Computations
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee wage per day" + empWage);
            Console.Read();
        }
    }
}
