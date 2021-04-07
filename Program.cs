using System;

namespace EmpWage1
{
    class Program
    {
        //constants
       public const int FULL_TIME = 1;
      public const  int PART_TIME = 2;
       public const int EMP_RATE_PER_HR = 20;
        public const int EMP_TOTAL_WORKING_DAY_PER_MONTH = 20;

        static void Main(string[] args)
        {
            
            //LOCAL VARIABLES
            int empHrs = 0;
            int empWage = 0;

            //inbuilt class
            Random random = new Random();
            int employeeCheck = random.Next(0, 5);

            Console.WriteLine("random value" + employeeCheck);

            //Selection statements
           switch(employeeCheck)
            {
                case FULL_TIME:
                    empHrs = 8;
                    break;

                case PART_TIME:
                    empHrs = 4;
                    break;

                default:
                    empHrs = 0;
                    break;
            }
            //Computations
            empWage = EMP_RATE_PER_HR * empHrs * EMP_TOTAL_WORKING_DAY_PER_MONTH;
            Console.WriteLine("Employee wage per MONTH" + empWage);
            Console.Read();
        }
    }
}
