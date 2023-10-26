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
       
         static double GetSumMore(params double[] nums) 
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        // ------ END OF FUNCTIONS ------

        static void Main(string[] args)
        {
            Console.WriteLine("1+2+3 = {0}", GetSumMore(1, 2, 3));

        }
    }
}