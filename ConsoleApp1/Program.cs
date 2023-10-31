using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        // ------ FUNCTIONS ------
        // <Access Specifier> <Return Type> <Method Name>(Parameters)
        // { <Body> }
        // Access Specifier determines whether the function can be called from another class
        // Public: Can be accessed from another cl
        // Private: Can't be accessed from another cl
        // Protected: Can't be accessed by class but can be by derived classes

        

        // ------ END OF FUNCTIONS ------

        static void Main(string[] args)
        {
            DateTime awesomeDate = new DateTime(2004, 9, 5);
            Console.WriteLine("Day of the week {0}", awesomeDate.DayOfWeek);
            awesomeDate = awesomeDate.AddDays(6);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(2);
            Console.WriteLine("New Date : {0}", awesomeDate.Date);

            TimeSpan lunchTime = new TimeSpan(13, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine("New time : {0}", lunchTime.ToString());
        }
    }
}