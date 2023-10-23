using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biggest double : {0}", Double.MaxValue);
            double dblPiVal = 3.14159265358979;
            double dblBigNumber = 3.00000000002;
            Console.WriteLine("DBL : PI + BigNum = {0}", dblPiVal + dblBigNumber);

            Console.WriteLine("Biggest Float : {0}", float.MaxValue);
            double fltPiVal = 3.141592F;
            double fltBigNumber = 3.000002F;
            Console.WriteLine("FLT : PI + BigNum = {0}", fltPiVal + fltBigNumber);
        }
    }
}