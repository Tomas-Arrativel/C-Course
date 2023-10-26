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
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;
            Console.WriteLine("Random num : ", secretNumber);

            do
            {
                Console.WriteLine("Enter a number between 1 & 10");
                numberGuessed = Convert.ToInt32(Console.ReadLine());
            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed it, secret number was {0}", secretNumber);
        }
    }
}