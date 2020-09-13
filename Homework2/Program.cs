/// Chapter No. 1 Exercise No. 1
/// File Name: Homework 2 part 1
/// @author: Dakota Durst
/// Date: September 12, 2020
///
/// Problem Statement: Use string variables set to your first and last name and convert the name into pig latin.
///
///
/// Overall Plan:
/// 1) initialize variables needed (first, last, pig first, pig last)
/// 2) check to make sure variables are correctly assigned the letters needed
/// 3) convert the string name to pig latin and upper case first letter
/// 4) Print result on screen

using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            //initialize first and last name variables
            String first_name = "mark";
            String last_name = "aloka";
            // (check to see in variable assigned correctly) System.out.println(first_name);
            //System.out.println(last_name);

            String fn_1st = first_name.Substring(0, 1);
            String ln_1st = last_name.Substring(0, 1);
            // check to see if it works System.out.println(fn_1st);
            // check to see if it works System.out.println(ln_1st);
            String pig_first = first_name.Substring(1, 1).ToUpper() + first_name.Substring(2) + fn_1st + "ay";
            String pig_last = last_name.Substring(1, 1).ToUpper() + last_name.Substring(2) + ln_1st + "ay";
            Console.WriteLine(pig_first);
            Console.WriteLine(pig_last);

        }


    }
}