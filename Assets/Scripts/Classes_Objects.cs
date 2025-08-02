using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Yooooo
{

    public class Person
    {
        public string name;
        public int age;

        public Person()
        {
            name = "Default Human";
            age = 100;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void GetDetails()
        {
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Age is " + age);
        }
    }

    public class Classes_Objects
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Dev";
            person.age = 23;
            person.GetDetails();

            Person person1 = new Person();
            person1.name = "Devesh";
            person.age = 23;
            person.GetDetails();

            Person person2 = new Person();
            person2.GetDetails();

            Person person3= new Person("Anshul", 29);
            person3.GetDetails();
        }
    }
}