using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Yoo
{
    public class Loops
    {
        public static void Main(string[] args)
        {
            // For loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hellow World! " + i);
            }

            // While loop
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine("Hellow World! " + x);
                x++;
            }

            // Do While loop
            int y = 0;
            do
            {
                Console.WriteLine("Hellow World! " + y);
                y++;
            }while(y < 10);
        }
    }
}