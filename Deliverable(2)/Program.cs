/*
 * Author: XIomara Montes Gil
 * Date: 1/19/2023
 * Description: C# Console Application for calculating letter grades
 */

using System;
using System.Linq.Expressions;

namespace Deliverable_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");

            try
            {

                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is A");
                }

                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                }
            }
            catch
            {
                Console.WriteLine("Enter a numerical value");
            }
        }
    }
}