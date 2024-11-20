using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_year_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input: year to check
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Check if the year is a leap year
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("{0} is a leap year.", year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a leap year.", year);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is a leap year.", year);
                }
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.", year);
            }
        }

    }
}

