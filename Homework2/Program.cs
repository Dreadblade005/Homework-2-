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