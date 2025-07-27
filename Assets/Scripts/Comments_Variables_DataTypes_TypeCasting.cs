using System;
using System.Linq;
class HelloWorld{
    public static void Main(string[] args){
        // Console.WriteLine("Comments");
        /* 
        Console.WriteLine("Line 2");
        Console.WriteLine("Line 3"); 
        */

        // Type Variable = Data
        int number = 12;
        Console.WriteLine(number);
        int val = 2147483647;
        long val2 = 2147483648;
        byte val3 = 255;
        float val4 = 12.5f;
        decimal val5 = 123.33M;
        double val6 = 12.5D;
        char ch = 'A';
        bool b = true;
        string str = "Dev";
        string name = "Dev" + "esh";
        Console.WriteLine(str.Length);
        Console.WriteLine(str.Equals(name));
        Console.WriteLine(str.IndexOf("D"));
        Console.WriteLine(str.ElementAt(2));

        int x = (int)22.5f;
        float y = 22.5f;
        int z = int(y);
    }
}