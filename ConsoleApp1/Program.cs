using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool canIVote = true;

            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest integer : {0}", int.MinValue);

            Console.WriteLine("biggest long : {0}", long.MaxValue);
            Console.WriteLine("Smallest long : {0}", long.MinValue);

            decimal decPiVal = 3.14159265M;
            decimal decBigNum = 3.0000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

            Console.WriteLine("bigst decim: {0}", decimal.MaxValue);
            Console.WriteLine("small decim: {0}", decimal.MinValue);

        }
    }
}