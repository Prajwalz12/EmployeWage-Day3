using System;

namespace EmpWage1
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;

            Random random = new Random();

            int check = random.Next(0, 2);

            if (check == isPresent)
            {
                Console.WriteLine("is present");
            }
            else
            {
                Console.WriteLine("is absent");
            }
            }
        }
    }


