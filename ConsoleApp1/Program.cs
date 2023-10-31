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

        static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }
        static double GetSum2(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }



        // ------ END OF FUNCTIONS ------

        static void Main(string[] args)
        {
            Console.WriteLine("5.0 + 4.5 = {0} double", GetSum2(5.0, 4.5));
            Console.WriteLine("5.0 + 4.5 = {0} string", GetSum2("5.0", "4.5"));
        }
    }
}