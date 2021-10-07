using System;

namespace EmpWage1
{
    class Program
    {
        static int Main(string[] args)
        {
            int isPresent = 1;

            int emprateperHr = 20;
            int empHr = 8;
            Random random = new Random();

            int check = random.Next(0, 2);

            if (check == isPresent)
            {
                Console.WriteLine("is present");
                int salary;
                return salary = (emprateperHr * empHr);
            }
            else
            {
                int salary;
                return salary = 0;
            }
        }
    }
}


