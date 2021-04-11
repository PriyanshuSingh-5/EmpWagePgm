using System;

namespace EmpWage1
{
    class Program
    {
        //constants
        public const int Full_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        static void Main(string[] args)
        {
            //local variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int hrs = 0;
            int WorkingDays = 1;


            //inbuilt class
            Random random = new Random();
            while (hrs < MAX_WORKING_HRS && WorkingDays <= MAX_WORKING_DAYS)
            {
                WorkingDays++;
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
                hrs = empHrs;
                totalEmpWage += empWage;//totalEmpWage=totalWage+empWage
            }
            Console.WriteLine("Emp wage for " + WorkingDays + "days" + totalEmpWage);
            Console.WriteLine("Working hrs " + hrs);
            Console.Read();
        }
    }
}

