using System;

namespace _4._1._5_Static_Field
{
    class Person
    {
        static public int TotalInstance;
        public string _name;

        public Person(string name)
        {
            TotalInstance++;
            _name = name;
            Console.WriteLine($"Welecom, " + name + $"!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Homin = new Person("Homin");
            Console.WriteLine(Person.TotalInstance);
            
            var Minho = new Person("Minho");
            Console.WriteLine(Person.TotalInstance);
        }
    }
}