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
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 500;
            Console.WriteLine("Area of rect1 : {0}", rect1.Area());
            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("rect2.length : {0}", rect2.length);

            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaaaw"
            };

            Console.WriteLine("# of Animals {0}", Animal.GetNumAnimals());

            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("Rectangle", 5, 6));

            int? randNum = null;
            if(randNum == null) { Console.WriteLine("randNum is Null"); }
            if(!randNum.HasValue) { Console.WriteLine("randNum is null"); }
        }

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1) { length = l; width = w; }
            public double Area()
            {
                return length * width;
            }
        }
    }
}