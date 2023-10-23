using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency : {0:c}",23.553);
            Console.WriteLine("padd w 0 : {0:d4}", 23);
            Console.WriteLine("3 Decimals : {0:f3}", 23.3434443);
            Console.WriteLine("Commas : {0:n4}", 2300);
        }
    }
}