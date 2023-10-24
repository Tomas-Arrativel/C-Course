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
            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("favNum 0 : {0}", favNums[0]);
            string[] customers = { "Bob", "Alice", "Sue" };
            var employees = new[] { "Mike", "Paul", "Rick" };
            object[] randomArray = { "paul", 45, 1.234 };
            Console.WriteLine("randomArray 0 : {0}", randomArray[0].GetType());
            Console.WriteLine("Array Size : {0}", randomArray.Length);
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array : {0} : Value : {1}", i, randomArray[i]);
            }
            Console.WriteLine("-------------------");
            string[,] custName = new string[2, 2] { { "Bob", "Smaith" }, { "Sally", "Smith" } };
            Console.WriteLine("MD Value : {0}", custName.GetValue(0, 1));
           
            for (int j = 0; j < custName.GetLength(0); j++)
            {
                for (int k = 0; k < custName.GetLength(0); k++)
                {
                    Console.WriteLine("{0} ", custName[j, k]);
                }
            }

            int[] randNums = { 1, 4, 2, 6, 7 };
            PrintArray(randNums, "ForEach");
        
            Console.WriteLine("-------------------");
        }
    }
}