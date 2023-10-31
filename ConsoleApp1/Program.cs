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
       
         static void PrintInfo(string name, int zipcode)
        {
            Console.WriteLine("{0} lives in the zipcode {1}", name, zipcode);
        }

        // ------ END OF FUNCTIONS ------

        static void Main(string[] args)
        {
            PrintInfo(zipcode: 15147, name: "Tomás Arrativel");

        }
    }
}