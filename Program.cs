using System;

namespace EmpWage1
{
    class Program
    {
       
           public const int Full_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            //local variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            //inbuilt class
            Random random = new Random();
            for (int day = 0; day < WORKING_DAYS; day++)
            {
                int employeeCheck = random.Next(0, 3);

                //Console.WriteLine("random value " + employeeCheck);
                //selection statements

                switch (employeeCheck)
                {
                    case Full_TIME:
                        empHrs = 8;
                        break;

                    case PART_TIME:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                //computation
                empWage = EMP_RATE_PER_HR * empHrs;
                totalEmpWage += empWage;//totalEmpWage=totalWage+empWage
            }
            Console.WriteLine("Emp wage for 20 days " + totalEmpWage);
            Console.Read(); ;
        }
    }
}
