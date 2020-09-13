/// Chapter No. 1 Exercise No. 1
/// File Name: Homework week 2
/// @author: Dakota Durst
/// Date: September 12, 2020
///
/// Problem Statement: Ask user for an interger (fahrenheit) and convert number to Celsius with rounding
//
///
/// Overall Plan:
/// 1) Assign Fahrenheit and Celsius variables
/// 2) ASsk user for number and set input to Fahrenheit variable (convert to int)
/// 3) set formula for celsuius conversion
/// 4) print out value, round to 1 decimal
///




using System;

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double Fahrenheit;
            double Celsius;
            Console.WriteLine("Enter the degrees Fahrenheit you would like to translate to Celsius: ");
            Fahrenheit = Convert.ToInt32(Console.ReadLine());
            Celsius = 5 * (Fahrenheit - 32) / 9;
            Console.WriteLine(Fahrenheit + " degrees Fahrenheit = " + Math.Round(Celsius, 1) + " degrees Celsius");
        }
    }
}
