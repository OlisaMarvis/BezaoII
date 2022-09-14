using System;

namespace Next_20_leap_years
{
    public class Program
    {
      
        public static void PrintNext20LeapYears()
        {
            //Write a program that prints the next 20 leap years.


            var year = DateTime.Now.Year;
            var count = 0;
            while (count < 20)
            {
                year += 1;
                if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine("{0}. {1}", count + 1, year);
                    count += 1;
                }
            }

        }
        public static void Main(string[] args)
        {

            PrintNext20LeapYears();

        }
    }
}
