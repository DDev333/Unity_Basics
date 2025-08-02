using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Yoooo
{
    public class Functions
    {
        public static void Hello()
        {
            Console.WriteLine("Hello World!");
        }

        public static int Square(int n){
            return n * n;
        }

        public static void Main(string[] args)
        {
            Hello();
            Console.WriteLine(Square(4));
        }
    }
}