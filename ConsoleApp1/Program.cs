﻿using System;

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
            // Relational Operators : < > >= <= == !=
            // Logical Operators : && || !

            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            if ((age > 13) && (age < 19))
            {
                Console.WriteLine("Go to high school");
            }
            else { Console.WriteLine("Go to college"); }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }
            Console.WriteLine("! true = " + (!true));

            bool canDrive = age >= 16 ? true : false;

            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to day care");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to preschool");
                    break;
                case 5:
                    Console.WriteLine("Go to Kindergarten");
                    break;
                default:
                    Console.WriteLine("Go to another school");
                    goto OtherSchool;
            }

        OtherSchool:
            Console.WriteLine("Elementary, Middle, High school");
        }
    }
}