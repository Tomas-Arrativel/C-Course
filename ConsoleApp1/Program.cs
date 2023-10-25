using System;

namespace ConsoleApp1
{
    public class Program
    {
        // ------ FUNCTIONS ------

        static void PrintArray(int[] intArray, string mess)
        {
            foreach(int k in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, k);
            }
        }

        // ------ END OF FUNCTIONS ------

        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                if(i % 2 == 0)
                {
                    i++;
                    continue;
                }
                if (i == 9) break;
                Console.WriteLine(i);
                i++;
            }
        }
    }
}