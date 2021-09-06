using System;

namespace Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Write a year and hit [Enter] >");
            int.TryParse(Console.ReadLine(), out int input);
            Console.WriteLine(IsLeapYear(input)? "yay" : "nay");
        }

        ///<summary>
        /// Is 'year' a leap year?
        ///</summary>
        public static bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
                return true;
            if (year % 100 == 0)
                return false;
            if (year % 4 == 0)
                return true;
            return false;
        }
    }
}
