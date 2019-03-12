using System;

namespace DaysBetween
{
    public static class Program
    {
        public static void Main()
        {
            // TODO:  Get two dates from the user.
            Console.WriteLine("Enter the first date:");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second date:");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("No of days between the given dates is:{0} ", DaysBetween(date1,date2));
            Console.ReadLine();
        }
        // TODO: Create that has a method that counts the number of days between two different dates.
        public static int DaysBetween(DateTime firstDate, DateTime secondDate)
        {
            int result = (firstDate - secondDate).Days;

            //Console.WriteLine(result);
            //Console.ReadLine();
            
            return Math.Abs(result);
        }
    }
}
