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
            Animal cat = new Animal();
            cat.SetName("Whiskers");
            cat.Sound = "Meow";
            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);
            cat.Owner = "Tomás";
            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);
            Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);
            Console.WriteLine("# of animals : {0}", Animal.NumOfAnimals);
        }
    }
}