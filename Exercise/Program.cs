using System;

namespace Exercise
{
    public class Program
    {
		private const int StartYear = 1582;

		public static void Main(string[] args)
        {
            Console.Write("Write a year and hit [Enter] >");
            if (int.TryParse(Console.ReadLine(), out int input))
			{
				if (input > StartYear)
				{
					Console.WriteLine(IsLeapYear(input) ? "yay" : "nay");
				}
				else
				{
					Console.WriteLine("Year must be after 1582!");
				}
			}
			else
            {
                Console.WriteLine("Parse error");
            }
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
