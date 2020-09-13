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
