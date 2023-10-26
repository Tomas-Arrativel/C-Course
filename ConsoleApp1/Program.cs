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
       
        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }

        // ------ END OF FUNCTIONS ------

        static void Main(string[] args)
        {
            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before Swap num1 : {0} num2 : {1}", num3, num4);
            Swap(ref num3, ref num4);
            Console.WriteLine("After Swap num1 : {0} num2 : {1}", num3, num4);

        }
    }
}