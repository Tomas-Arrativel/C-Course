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
       
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        // ------ END OF FUNCTIONS ------

        static void Main(string[] args)
        {
            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}", solution);
        }
    }
}