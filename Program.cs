using System;

namespace EmpWage1
{
    class Program
    {
        static void Main(string[] args)
        {
            int present = 1;

            Random random = new Random();
            int employeeCheck = random.Next(0, 2);

            Console.WriteLine("random value" + employeeCheck);
            if (employeeCheck == present)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");

            Console.Read();
        }
    }
}
