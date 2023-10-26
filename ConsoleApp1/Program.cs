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
       
        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }

        // ------ END OF FUNCTIONS ------

        static void Main(string[] args)
        {
            double x = 5;
            double y = 4;
            Console.WriteLine("5 + 4 = {0}", GetSum(x, y));
            Console.WriteLine("x = {0}", x);
        }
    }
}