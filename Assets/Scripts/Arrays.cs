using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Yooo
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            int[] val = { 2, 3, 4, 5 }; //dynamic
            int[] arr = new int[5] { 1, 2, 3, 4, 5 }; //static
            Console.WriteLine(arr[2]);
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(val.Length);
            Array.Sort(arr);
            int idx = Array.IndexOf(arr, 3);
            Console.WriteLine(idx);
            Console.WriteLine(val.Max());
            Console.WriteLine(val.Min());
            Console.WriteLine(val.Sum());
        }
    }
}