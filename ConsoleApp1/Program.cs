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

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0}, with the code {1}", cc, (int)cc);
        }

        // ------ END OF FUNCTIONS ------

        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }

        static void Main(string[] args)
        {
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);
        }
    }
}