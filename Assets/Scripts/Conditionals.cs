using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Yo
{
    public class Conditionals
    {
        public static void Main(string[] args)
        {
            bool isRaining = true;
            if (isRaining == true)
            {
                Console.WriteLine("Take our umbrella");
            }
            else
            {
                Console.WriteLine("Don't take your umbrella");
            }

            int age = 15;
            if (age >= 18)
            {
                Console.WriteLine("Eligible to vote");
            }
            else if (age < 18 && age > 0)
            {
                Console.WriteLine("Not eligible to vote");
            }
            else
            {
                Console.WriteLine("Invalid age");
            }

            string statement = 4 > 2 ? "4 is assigned" : "2 is assigned";
            Console.WriteLine(statement);

            char ch = 'A';
            switch (ch)
            {
                case 'A':
                    Console.WriteLine("Grade A");
                    break;
                case 'B':
                    Console.WriteLine("Grade B");
                    break;
                default:
                    Console.WriteLine("Grade C");
                    break;
                
            }
        }
    }
}