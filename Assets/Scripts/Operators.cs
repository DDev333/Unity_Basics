using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hi
{
    public class Operators
    {
        public static void main(string[] args)
        {
            int a = 2;
            int b = 8;

            // Arithmetic Operators
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine(a++);
            Console.WriteLine(a--);

            // Relational Operators
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            // Logical Operators
            Console.WriteLine(a == b && a > b);
            Console.WriteLine(a == b || a > b);
            Console.WriteLine(!(a == b && a > b));
        }
    }
}